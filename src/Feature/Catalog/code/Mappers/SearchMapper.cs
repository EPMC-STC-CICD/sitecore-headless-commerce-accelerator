﻿//    Copyright 2020 EPAM Systems, Inc.
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

namespace Wooli.Feature.Catalog.Mappers
{
    using System.Diagnostics.CodeAnalysis;

    using AutoMapper;

    using Foundation.DependencyInjection;

    using Profiles;

    using Mapper = Foundation.Base.Mappers.Mapper;

    [Service(typeof(ISearchMapper), Lifetime = Lifetime.Singleton)]
    [ExcludeFromCodeCoverage]
    public class SearchMapper : Mapper, ISearchMapper
    {
        public SearchMapper()
        {
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile<SearchProfile>());
            this.InnerMapper = new AutoMapper.Mapper(configuration);
        }
    }
}