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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// This is the response object from the GetEnvironmentBlueprintConfiguration operation.
    /// </summary>
    public partial class GetEnvironmentBlueprintConfigurationResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _domainId;
        private List<string> _enabledRegions = new List<string>();
        private string _environmentBlueprintId;
        private string _manageAccessRoleArn;
        private string _provisioningRoleArn;
        private Dictionary<string, Dictionary<string, string>> _regionalParameters = new Dictionary<string, Dictionary<string, string>>();
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when this blueprint was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the Amazon DataZone domain where this blueprint exists.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property EnabledRegions. 
        /// <para>
        /// The Amazon Web Services regions in which this blueprint is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public List<string> EnabledRegions
        {
            get { return this._enabledRegions; }
            set { this._enabledRegions = value; }
        }

        // Check to see if EnabledRegions property is set
        internal bool IsSetEnabledRegions()
        {
            return this._enabledRegions != null && this._enabledRegions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentBlueprintId. 
        /// <para>
        /// The ID of the blueprint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EnvironmentBlueprintId
        {
            get { return this._environmentBlueprintId; }
            set { this._environmentBlueprintId = value; }
        }

        // Check to see if EnvironmentBlueprintId property is set
        internal bool IsSetEnvironmentBlueprintId()
        {
            return this._environmentBlueprintId != null;
        }

        /// <summary>
        /// Gets and sets the property ManageAccessRoleArn. 
        /// <para>
        /// The ARN of the manage access role with which this blueprint is created.
        /// </para>
        /// </summary>
        public string ManageAccessRoleArn
        {
            get { return this._manageAccessRoleArn; }
            set { this._manageAccessRoleArn = value; }
        }

        // Check to see if ManageAccessRoleArn property is set
        internal bool IsSetManageAccessRoleArn()
        {
            return this._manageAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningRoleArn. 
        /// <para>
        /// The ARN of the provisioning role with which this blueprint is created.
        /// </para>
        /// </summary>
        public string ProvisioningRoleArn
        {
            get { return this._provisioningRoleArn; }
            set { this._provisioningRoleArn = value; }
        }

        // Check to see if ProvisioningRoleArn property is set
        internal bool IsSetProvisioningRoleArn()
        {
            return this._provisioningRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RegionalParameters. 
        /// <para>
        /// The regional parameters of the blueprint.
        /// </para>
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> RegionalParameters
        {
            get { return this._regionalParameters; }
            set { this._regionalParameters = value; }
        }

        // Check to see if RegionalParameters property is set
        internal bool IsSetRegionalParameters()
        {
            return this._regionalParameters != null && this._regionalParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when this blueprint was upated.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}