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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the BatchDescribeTypeConfigurations operation.
    /// Returns configuration data for the specified CloudFormation extensions, from the CloudFormation
    /// registry in your current account and Region.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry-set-configuration.html">Edit
    /// configuration data for extensions in your account</a> in the <i>CloudFormation User
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class BatchDescribeTypeConfigurationsRequest : AmazonCloudFormationRequest
    {
        private List<TypeConfigurationIdentifier> _typeConfigurationIdentifiers = AWSConfigs.InitializeCollections ? new List<TypeConfigurationIdentifier>() : null;

        /// <summary>
        /// Gets and sets the property TypeConfigurationIdentifiers. 
        /// <para>
        /// The list of identifiers for the desired extension configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<TypeConfigurationIdentifier> TypeConfigurationIdentifiers
        {
            get { return this._typeConfigurationIdentifiers; }
            set { this._typeConfigurationIdentifiers = value; }
        }

        // Check to see if TypeConfigurationIdentifiers property is set
        internal bool IsSetTypeConfigurationIdentifiers()
        {
            return this._typeConfigurationIdentifiers != null && (this._typeConfigurationIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}