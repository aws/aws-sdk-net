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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the PutAccountProperties operation.
    /// Sets account-level properties for the caller's Amazon Web Services account. Account
    /// properties are configuration settings that control account-wide IAM features such
    /// as Role Manager.
    /// 
    ///  
    /// <para>
    /// Specify properties as key-value pairs in <c>Namespace/PropertyName</c> format. All
    /// properties in a single request must belong to the same namespace. Use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetAccountProperties.html">GetAccountProperties</a>
    /// to view the current properties.
    /// </para>
    /// </summary>
    public partial class PutAccountPropertiesRequest : AmazonIdentityManagementServiceRequest
    {
        private Dictionary<string, string> _properties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// A map of property key-value pairs to set. All keys must belong to the same namespace.
        /// </para>
        ///  
        /// <para>
        /// Each key uses the format <c>Namespace/PropertyName</c>. The key must contain exactly
        /// one <c>/</c> separating the namespace from the property name, and cannot start or
        /// end with <c>/</c>.
        /// </para>
        ///  
        /// <para>
        /// The service validates each value based on the property key's expected type. For example,
        /// boolean properties expect <c>true</c> or <c>false</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && (this._properties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}