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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDataAccessor operation.
    /// Updates an existing data accessor. This operation allows modifying the action configurations
    /// (the allowed actions and associated filters) and the display name of the data accessor.
    /// It does not allow changing the IAM role associated with the data accessor or other
    /// core properties of the data accessor.
    /// </summary>
    public partial class UpdateDataAccessorRequest : AmazonQBusinessRequest
    {
        private List<ActionConfiguration> _actionConfigurations = AWSConfigs.InitializeCollections ? new List<ActionConfiguration>() : null;
        private string _applicationId;
        private DataAccessorAuthenticationDetail _authenticationDetail;
        private string _dataAccessorId;
        private string _displayName;

        /// <summary>
        /// Gets and sets the property ActionConfigurations. 
        /// <para>
        /// The updated list of action configurations specifying the allowed actions and any associated
        /// filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<ActionConfiguration> ActionConfigurations
        {
            get { return this._actionConfigurations; }
            set { this._actionConfigurations = value; }
        }

        // Check to see if ActionConfigurations property is set
        internal bool IsSetActionConfigurations()
        {
            return this._actionConfigurations != null && (this._actionConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticationDetail. 
        /// <para>
        /// The updated authentication configuration details for the data accessor. This specifies
        /// how the ISV will authenticate when accessing data through this data accessor.
        /// </para>
        /// </summary>
        public DataAccessorAuthenticationDetail AuthenticationDetail
        {
            get { return this._authenticationDetail; }
            set { this._authenticationDetail = value; }
        }

        // Check to see if AuthenticationDetail property is set
        internal bool IsSetAuthenticationDetail()
        {
            return this._authenticationDetail != null;
        }

        /// <summary>
        /// Gets and sets the property DataAccessorId. 
        /// <para>
        /// The unique identifier of the data accessor to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string DataAccessorId
        {
            get { return this._dataAccessorId; }
            set { this._dataAccessorId = value; }
        }

        // Check to see if DataAccessorId property is set
        internal bool IsSetDataAccessorId()
        {
            return this._dataAccessorId != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The updated friendly name for the data accessor.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=100)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

    }
}