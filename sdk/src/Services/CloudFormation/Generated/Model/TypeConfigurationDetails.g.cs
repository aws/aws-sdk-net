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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Detailed information concerning the specification of a CloudFormation extension in
    /// a given account and Region.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-set-configuration.html">Edit
    /// configuration data for extensions in your account</a> in the <i>CloudFormation User
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class TypeConfigurationDetails
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias specified for this configuration, if one was specified when the configuration
        /// was set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN for the configuration data, in this account and Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// A JSON string specifying the configuration data for the extension, in this account
        /// and Region.
        /// </para>
        ///  
        /// <para>
        /// If a configuration hasn't been set for a specified extension, CloudFormation returns
        /// <c>{}</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 204800)]
        public string Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property IsDefaultConfiguration. 
        /// <para>
        /// Whether this configuration data is the default configuration for the extension.
        /// </para>
        /// </summary>
        public bool? IsDefaultConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IsDefaultConfiguration property is set.
        /// </summary>
        internal bool IsSetIsDefaultConfiguration() => this.IsDefaultConfiguration.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// When the configuration data was last updated for this extension.
        /// </para>
        ///  
        /// <para>
        /// If a configuration hasn't been set for a specified extension, CloudFormation returns
        /// <c>null</c>.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdated property is set.
        /// </summary>
        internal bool IsSetLastUpdated() => this.LastUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property TypeArn. 
        /// <para>
        /// The ARN for the extension, in this account and Region.
        /// </para>
        ///  
        /// <para>
        /// For public extensions, this will be the ARN assigned when you call the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_ActivateType.html">ActivateType</a>
        /// API operation in this account and Region. For private extensions, this will be the
        /// ARN assigned when you call the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_RegisterType.html">RegisterType</a>
        /// API operation in this account and Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TypeArn { get; set; }

        /// <summary>
        /// Checks to see if the TypeArn property is set.
        /// </summary>
        internal bool IsSetTypeArn() => this.TypeArn != null;

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the extension.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 204)]
        public string TypeName { get; set; }

        /// <summary>
        /// Checks to see if the TypeName property is set.
        /// </summary>
        internal bool IsSetTypeName() => this.TypeName != null;
    }
}
