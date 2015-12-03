/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// An immutable representation of a <a>RestApi</a> resource that can be called by users
    /// using <a>Stages</a>. A deployment must be associated with a <a>Stage</a> for it to
    /// be callable over the Internet.
    /// </summary>
    public partial class GetDeploymentResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, Dictionary<string, MethodSnapshot>> _apiSummary = new Dictionary<string, Dictionary<string, MethodSnapshot>>();
        private DateTime? _createdDate;
        private string _description;
        private string _id;

        /// <summary>
        /// Gets and sets the property ApiSummary. 
        /// <para>
        /// Gets a summary of the <a>RestApi</a> at the date and time that the deployment resource
        /// was created.
        /// </para>
        /// </summary>
        public Dictionary<string, Dictionary<string, MethodSnapshot>> ApiSummary
        {
            get { return this._apiSummary; }
            set { this._apiSummary = value; }
        }

        // Check to see if ApiSummary property is set
        internal bool IsSetApiSummary()
        {
            return this._apiSummary != null && this._apiSummary.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time that the deployment resource was created.
        /// </para>
        /// </summary>
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the deployment resource.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for the deployment resource.
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