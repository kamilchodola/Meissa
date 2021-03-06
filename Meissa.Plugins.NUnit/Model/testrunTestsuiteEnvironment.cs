﻿// <copyright file="testrunTestsuiteEnvironment.cs" company="Automate The Planet Ltd.">
// Copyright 2018 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>https://bellatrix.solutions/</site>

// <auto-generated/>
using System.Xml.Serialization;

namespace Meissa.Core.Model.NUnit
{
    [XmlType(AnonymousType = true)]
    public class testrunTestsuiteEnvironment
    {
        private string _frameworkversionField;

        private string _clrversionField;

        private string _osversionField;

        private string _platformField;

        private string _cwdField;

        private string _machinenameField;

        private string _userField;

        private string _userdomainField;

        private string _cultureField;

        private string _uicultureField;

        private string _osarchitectureField;

        [XmlAttribute("framework-version")]
        public string frameworkversion
        {
            get => _frameworkversionField;
            set => _frameworkversionField = value;
        }

        [XmlAttribute("clr-version")]
        public string clrversion
        {
            get => _clrversionField;
            set => _clrversionField = value;
        }

        [XmlAttribute("os-version")]
        public string osversion
        {
            get => _osversionField;
            set => _osversionField = value;
        }

        [XmlAttribute]
        public string platform
        {
            get => _platformField;
            set => _platformField = value;
        }

        [XmlAttribute]
        public string cwd
        {
            get => _cwdField;
            set => _cwdField = value;
        }

        [XmlAttribute("machine-name")]
        public string machinename
        {
            get => _machinenameField;
            set => _machinenameField = value;
        }

        [XmlAttribute]
        public string user
        {
            get => _userField;
            set => _userField = value;
        }

        [XmlAttribute("user-domain")]
        public string userdomain
        {
            get => _userdomainField;
            set => _userdomainField = value;
        }

        [XmlAttribute]
        public string culture
        {
            get => _cultureField;
            set => _cultureField = value;
        }

        [XmlAttribute]
        public string uiculture
        {
            get => _uicultureField;
            set => _uicultureField = value;
        }

        [XmlAttribute("os-architecture")]
        public string osarchitecture
        {
            get => _osarchitectureField;
            set => _osarchitectureField = value;
        }
    }
}
