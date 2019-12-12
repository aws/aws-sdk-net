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
 * Do not modify this file. This file is generated from the schemas-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Schemas.Model
{
    /// <summary>
    /// This is the response object from the LockServiceLinkedRole operation.
    /// </summary>
    public partial class LockServiceLinkedRoleResponse : AmazonWebServiceResponse
    {
        private bool? _canBeDeleted;
        private string _reasonOfFailure;
        private List<DiscovererSummary> _relatedResources = new List<DiscovererSummary>();

        /// <summary>
        /// Gets and sets the property CanBeDeleted.
        /// </summary>
        public bool CanBeDeleted
        {
            get { return this._canBeDeleted.GetValueOrDefault(); }
            set { this._canBeDeleted = value; }
        }

        // Check to see if CanBeDeleted property is set
        internal bool IsSetCanBeDeleted()
        {
            return this._canBeDeleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReasonOfFailure.
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string ReasonOfFailure
        {
            get { return this._reasonOfFailure; }
            set { this._reasonOfFailure = value; }
        }

        // Check to see if ReasonOfFailure property is set
        internal bool IsSetReasonOfFailure()
        {
            return this._reasonOfFailure != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedResources.
        /// </summary>
        public List<DiscovererSummary> RelatedResources
        {
            get { return this._relatedResources; }
            set { this._relatedResources = value; }
        }

        // Check to see if RelatedResources property is set
        internal bool IsSetRelatedResources()
        {
            return this._relatedResources != null && this._relatedResources.Count > 0; 
        }

    }
}