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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
    /// Values</a> in the <i>AWS Elastic Beanstalk Developer Guide</i>.
    /// </summary>
    public partial class ConfigurationOptionSetting
    {
        private string _awsNamespace;
        private string _optionName;
        private string _resourceName;
        private string _value;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ConfigurationOptionSetting() { }

        /// <summary>
        /// Instantiates ConfigurationOptionSetting with the parameterized properties
        /// </summary>
        /// <param name="awsNamespace">A unique namespace that identifies the option's associated AWS resource.</param>
        /// <param name="optionName">The name of the configuration option.</param>
        /// <param name="value">The current value for the configuration option.</param>
        public ConfigurationOptionSetting(string awsNamespace, string optionName, string value)
        {
            _awsNamespace = awsNamespace;
            _optionName = optionName;
            _value = value;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// A unique namespace that identifies the option's associated AWS resource.
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property OptionName. 
        /// <para>
        /// The name of the configuration option.
        /// </para>
        /// </summary>
        public string OptionName
        {
            get { return this._optionName; }
            set { this._optionName = value; }
        }

        // Check to see if OptionName property is set
        internal bool IsSetOptionName()
        {
            return this._optionName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// A unique resource name for the option setting. Use it for a time–based scaling configuration
        /// option.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The current value for the configuration option.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}