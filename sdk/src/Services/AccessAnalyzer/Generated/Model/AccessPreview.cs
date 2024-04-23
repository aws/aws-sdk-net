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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains information about an access preview.
    /// </summary>
    public partial class AccessPreview
    {
        private string _analyzerArn;
        private Dictionary<string, Configuration> _configurations = AWSConfigs.InitializeCollections ? new Dictionary<string, Configuration>() : null;
        private DateTime? _createdAt;
        private string _id;
        private AccessPreviewStatus _status;
        private AccessPreviewStatusReason _statusReason;

        /// <summary>
        /// Gets and sets the property AnalyzerArn. 
        /// <para>
        /// The ARN of the analyzer used to generate the access preview.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AnalyzerArn
        {
            get { return this._analyzerArn; }
            set { this._analyzerArn = value; }
        }

        // Check to see if AnalyzerArn property is set
        internal bool IsSetAnalyzerArn()
        {
            return this._analyzerArn != null;
        }

        /// <summary>
        /// Gets and sets the property Configurations. 
        /// <para>
        /// A map of resource ARNs for the proposed resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, Configuration> Configurations
        {
            get { return this._configurations; }
            set { this._configurations = value; }
        }

        // Check to see if Configurations property is set
        internal bool IsSetConfigurations()
        {
            return this._configurations != null && (this._configurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the access preview was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID for the access preview.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the access preview.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Creating</c> - The access preview creation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Completed</c> - The access preview is complete. You can preview findings for external
        /// access to the resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> - The access preview creation has failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccessPreviewStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Provides more details about the current status of the access preview.
        /// </para>
        ///  
        /// <para>
        /// For example, if the creation of the access preview fails, a <c>Failed</c> status is
        /// returned. This failure can be due to an internal issue with the analysis or due to
        /// an invalid resource configuration.
        /// </para>
        /// </summary>
        public AccessPreviewStatusReason StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}