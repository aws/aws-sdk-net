/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// A specification identifying an individual configuration option along with its current
    /// value. For a list of possible namespaces and option values, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/command-options.html">Option
    /// Values</a> in the <i>Elastic Beanstalk Developer Guide</i>.
    /// </summary>
    public partial class ConfigurationOptionSetting
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public ConfigurationOptionSetting() { }

        /// <summary>
        /// Instantiates ConfigurationOptionSetting with the parameterized properties
        /// </summary>
        /// <param name="awsNamespace">A unique namespace that identifies the option's associated Amazon Web Services resource.</param>
        /// <param name="optionName">The name of the configuration option.</param>
        /// <param name="value">The current value for the configuration option.</param>
        public ConfigurationOptionSetting(string awsNamespace, string optionName, string value)
        {
            this.Namespace = awsNamespace;
            this.OptionName = optionName;
            this.Value = value;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// A unique namespace that identifies the option's associated Amazon Web Services resource.
        /// </para>
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property OptionName. 
        /// <para>
        /// The name of the configuration option.
        /// </para>
        /// </summary>
        public string OptionName { get; set; }

        /// <summary>
        /// Checks to see if the OptionName property is set.
        /// </summary>
        internal bool IsSetOptionName() => this.OptionName != null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// A unique resource name for the option setting. Use it for a time–based scaling configuration
        /// option.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The current value for the configuration option.
        /// </para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
