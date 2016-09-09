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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Contains information about a resource identified by a Trusted Advisor check.
    /// </summary>
    public partial class TrustedAdvisorResourceDetail
    {
        private bool? _isSuppressed;
        private List<string> _metadata = new List<string>();
        private string _region;
        private string _resourceId;
        private string _status;

        /// <summary>
        /// Gets and sets the property IsSuppressed. 
        /// <para>
        /// Specifies whether the AWS resource was ignored by Trusted Advisor because it was marked
        /// as suppressed by the user.
        /// </para>
        /// </summary>
        public bool IsSuppressed
        {
            get { return this._isSuppressed.GetValueOrDefault(); }
            set { this._isSuppressed = value; }
        }

        // Check to see if IsSuppressed property is set
        internal bool IsSetIsSuppressed()
        {
            return this._isSuppressed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Additional information about the identified resource. The exact metadata and its order
        /// can be obtained by inspecting the <a>TrustedAdvisorCheckDescription</a> object returned
        /// by the call to <a>DescribeTrustedAdvisorChecks</a>. <b>Metadata</b> contains all the
        /// data that is shown in the Excel download, even in those cases where the UI shows just
        /// summary data. 
        /// </para>
        /// </summary>
        public List<string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && this._metadata.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The AWS region in which the identified resource is located.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The unique identifier for the identified resource.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status code for the resource identified in the Trusted Advisor check.
        /// </para>
        /// </summary>
        public string Status
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