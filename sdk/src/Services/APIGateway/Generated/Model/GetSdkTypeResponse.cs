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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
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
namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// A type of SDK that API Gateway can generate.
    /// </summary>
    public partial class GetSdkTypeResponse : AmazonWebServiceResponse
    {
        private List<SdkConfigurationProperty> _configurationProperties = AWSConfigs.InitializeCollections ? new List<SdkConfigurationProperty>() : null;
        private string _description;
        private string _friendlyName;
        private string _id;

        /// <summary>
        /// Gets and sets the property ConfigurationProperties. 
        /// <para>
        /// A list of configuration properties of an SdkType.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SdkConfigurationProperty> ConfigurationProperties
        {
            get { return this._configurationProperties; }
            set { this._configurationProperties = value; }
        }

        // Check to see if ConfigurationProperties property is set
        internal bool IsSetConfigurationProperties()
        {
            return this._configurationProperties != null && (this._configurationProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of an SdkType.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FriendlyName. 
        /// <para>
        /// The user-friendly name of an SdkType instance.
        /// </para>
        /// </summary>
        public string FriendlyName
        {
            get { return this._friendlyName; }
            set { this._friendlyName = value; }
        }

        // Check to see if FriendlyName property is set
        internal bool IsSetFriendlyName()
        {
            return this._friendlyName != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of an SdkType instance.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}