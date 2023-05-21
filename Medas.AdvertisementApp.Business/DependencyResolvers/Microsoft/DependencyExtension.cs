﻿using AutoMapper;
using FluentValidation;
using Medas.AdvertisementApp.Business.Interfaces;
using Medas.AdvertisementApp.Business.Mappings;
using Medas.AdvertisementApp.Business.Services;
using Medas.AdvertisementApp.Business.ValidationRules;
using Medas.AdvertisementApp.Dtos.AdvertisementDtos;
using Medas.AdvertisementApp.Dtos.AppUserDtos;
using Medas.AdvertisementApp.Dtos.GenderDtos;
using Medas.AdvertisementApp.Dtos.ProvidedServiceDtos;
using Medas.AdvirsementApp.DataAccess.Contexts;
using Medas.AdvirsementApp.DataAccess.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medas.AdvertisementApp.Business.DependencyResolvers.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AdvertisementContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("Local"));
            });
            var mapperConfiguration = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new ProvidedServiceProfile());
                opt.AddProfile(new AdvertisementProfile());
                opt.AddProfile(new AppUserProfile());
                opt.AddProfile(new GenderProfile());
            });
            var mapper=mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);

           
            services.AddTransient<IValidator<ProvidedServiceCreateDto>,ProvidedServiceCreateDtoValidator>();
            services.AddTransient<IValidator<ProvidedServiceUpdateDto>,ProvidedServiceUpdateDtoValidator>();
            services.AddTransient<IValidator<AdvertisementCreateDto>, AdvertisementCreateDtoValidator>();
            services.AddTransient<IValidator<AdvertisementUpdateDto>, AdvertisementUpdateDtoValidator>();
            services.AddTransient<IValidator<AppUserCreateDto>,AppUserCreateDtoValidator>();
            services.AddTransient<IValidator<AppUserUpdateDto>,AppUserUpdateDtoValidator>();
            services.AddTransient<IValidator<GenderCreateDto>, GenderCreateDtoValidator>();
            services.AddTransient<IValidator<GenderUpdateDto>,GenderUpdateDtoValidator>();



            services.AddScoped<IUow, Uow>();
            services.AddScoped<IProvidedServiceService, ProvidedServiceService>();
            services.AddScoped<IAdvertisementService, AdvertisementService>();
            services.AddScoped<IAppUserService,AppUserService>();
            services.AddScoped<IGenderService, GenderService>();
        }
    }
}
