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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Detailed information concerning the specification of a CloudFormation extension in
    /// a given account and region.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-register.html#registry-set-configuration">Configuring
    /// extensions at the account level</a> in the <i>CloudFormation User Guide</i>.
    /// </para>
    /// </summary>
    public partial class TypeConfigurationDetails
    {
        private string _alias;
        private string _arn;
        private string _configuration;
        private bool? _isDefaultConfiguration;
        private DateTime? _lastUpdated;
        private string _typeArn;
        private string _typeName;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias specified for this configuration, if one was specified when the configuration
        /// was set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the configuration data, in this account and region.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// A JSON string specifying the configuration data for the extension, in this account
        /// and region.
        /// </para>
        ///  
        /// <para>
        /// If a configuration hasn't been set for a specified extension, CloudFormation returns
        /// <code>{}</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=204800)]
        public string Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property IsDefaultConfiguration. 
        /// <para>
        /// Whether or not this configuration data is the default configuration for the extension.
        /// </para>
        /// </summary>
        public bool IsDefaultConfiguration
        {
            get { return this._isDefaultConfiguration.GetValueOrDefault(); }
            set { this._isDefaultConfiguration = value; }
        }

        // Check to see if IsDefaultConfiguration property is set
        internal bool IsSetIsDefaultConfiguration()
        {
            return this._isDefaultConfiguration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// When the configuration data was last updated for this extension.
        /// </para>
        ///  
        /// <para>
        /// If a configuration hasn't been set for a specified extension, CloudFormation returns
        /// <code>null</code>.
        /// </para>
        /// </summary>
        public DateTime LastUpdated
        {
            get { return this._lastUpdated.GetValueOrDefault(); }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TypeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the extension, in this account and region.
        /// </para>
        ///  
        /// <para>
        /// For public extensions, this will be the ARN assigned when you <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_ActivateType.html">activate
        /// the type</a> in this account and region. For private extensions, this will be the
        /// ARN assigned when you <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_RegisterType.html">register
        /// the type</a> in this account and region.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string TypeArn
        {
            get { return this._typeArn; }
            set { this._typeArn = value; }
        }

        // Check to see if TypeArn property is set
        internal bool IsSetTypeArn()
        {
            return this._typeArn != null;
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=204)]
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

    }
}