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

namespace Wooli.Foundation.Base.Services.Context
{
    using DependencyInjection;

    using Sitecore.Abstractions;
    using Sitecore.Data;
    using Sitecore.Globalization;
    using Sitecore.Sites;

    [Service(typeof(ISitecoreContext), Lifetime = Lifetime.Singleton)]
    public class SitecoreContext : ISitecoreContext
    {
        public Language Language => Sitecore.Context.Language;

        public SiteContext Site => Sitecore.Context.Site;

        public Database Database => Sitecore.Context.Database;

        public BaseJob Job => Sitecore.Context.Job;
    }
}