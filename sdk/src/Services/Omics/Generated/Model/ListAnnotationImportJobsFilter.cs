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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Omics.Model
{
    /// <summary>
    /// A filter for annotation import jobs.
    /// </summary>
    public partial class ListAnnotationImportJobsFilter
    {
        private JobStatus _status;
        private string _storeName;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A status to filter on.
        /// </para>
        /// </summary>
        public JobStatus Status
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
        /// Gets and sets the property StoreName. 
        /// <para>
        /// A store name to filter on.
        /// </para>
        /// </summary>
        public string StoreName
        {
            get { return this._storeName; }
            set { this._storeName = value; }
        }

        // Check to see if StoreName property is set
        internal bool IsSetStoreName()
        {
            return this._storeName != null;
        }

    }
}