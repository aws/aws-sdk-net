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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// This is the response object from the GetDataAccessor operation.
    /// </summary>
    public partial class GetDataAccessorResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ActionConfigurations. 
        /// <para>
        /// The list of action configurations specifying the allowed actions and any associated
        /// filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ActionConfiguration> ActionConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ActionConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ActionConfigurations property is set.
        /// </summary>
        internal bool IsSetActionConfigurations() => this.ActionConfigurations != null && (this.ActionConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the Amazon Q Business application associated with this data
        /// accessor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property AuthenticationDetail. 
        /// <para>
        /// The authentication configuration details for the data accessor. This specifies how
        /// the ISV authenticates when accessing data through this data accessor.
        /// </para>
        /// </summary>
        public DataAccessorAuthenticationDetail AuthenticationDetail { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationDetail property is set.
        /// </summary>
        internal bool IsSetAuthenticationDetail() => this.AuthenticationDetail != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the data accessor was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DataAccessorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data accessor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1284)]
        public string DataAccessorArn { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessorArn property is set.
        /// </summary>
        internal bool IsSetDataAccessorArn() => this.DataAccessorArn != null;

        /// <summary>
        /// Gets and sets the property DataAccessorId. 
        /// <para>
        /// The unique identifier of the data accessor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string DataAccessorId { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessorId property is set.
        /// </summary>
        internal bool IsSetDataAccessorId() => this.DataAccessorId != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The friendly name of the data accessor.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property IdcApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Identity Center application associated with
        /// this data accessor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 1224)]
        public string IdcApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the IdcApplicationArn property is set.
        /// </summary>
        internal bool IsSetIdcApplicationArn() => this.IdcApplicationArn != null;

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role for the ISV associated with this data
        /// accessor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1284)]
        public string Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the data accessor was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
