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
 * Do not modify this file. This file is generated from the mobile-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mobile.Model
{
    /// <summary>
    /// Result structure used in response to request to delete a project.
    /// </summary>
    public partial class DeleteProjectResponse : AmazonWebServiceResponse
    {
        private List<Resource> _deletedResources = new List<Resource>();
        private List<Resource> _orphanedResources = new List<Resource>();

        /// <summary>
        /// Gets and sets the property DeletedResources. 
        /// <para>
        ///  Resources which were deleted. 
        /// </para>
        /// </summary>
        public List<Resource> DeletedResources
        {
            get { return this._deletedResources; }
            set { this._deletedResources = value; }
        }

        // Check to see if DeletedResources property is set
        internal bool IsSetDeletedResources()
        {
            return this._deletedResources != null && this._deletedResources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OrphanedResources. 
        /// <para>
        ///  Resources which were not deleted, due to a risk of losing potentially important data
        /// or files. 
        /// </para>
        /// </summary>
        public List<Resource> OrphanedResources
        {
            get { return this._orphanedResources; }
            set { this._orphanedResources = value; }
        }

        // Check to see if OrphanedResources property is set
        internal bool IsSetOrphanedResources()
        {
            return this._orphanedResources != null && this._orphanedResources.Count > 0; 
        }

    }
}