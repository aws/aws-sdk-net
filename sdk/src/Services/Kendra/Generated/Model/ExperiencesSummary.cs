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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Summary information for your Amazon Kendra experience. You can create an Amazon Kendra
    /// experience such as a search application. For more information on creating a search
    /// application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
    /// a search experience with no code</a>.
    /// </summary>
    public partial class ExperiencesSummary
    {
        private DateTime? _createdAt;
        private List<ExperienceEndpoint> _endpoints = new List<ExperienceEndpoint>();
        private string _id;
        private string _name;
        private ExperienceStatus _status;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp when your Amazon Kendra experience was created.
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
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// The endpoint URLs for your Amazon Kendra experiences. The URLs are unique and fully
        /// hosted by Amazon Web Services.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<ExperienceEndpoint> Endpoints
        {
            get { return this._endpoints; }
            set { this._endpoints = value; }
        }

        // Check to see if Endpoints property is set
        internal bool IsSetEndpoints()
        {
            return this._endpoints != null && this._endpoints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of your Amazon Kendra experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
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

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of your Amazon Kendra experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The processing status of your Amazon Kendra experience.
        /// </para>
        /// </summary>
        public ExperienceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}