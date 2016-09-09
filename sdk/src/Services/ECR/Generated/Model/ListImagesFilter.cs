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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECR.Model
{
    /// <summary>
    /// An object representing a filter on a <a>ListImages</a> operation.
    /// </summary>
    public partial class ListImagesFilter
    {
        private TagStatus _tagStatus;

        /// <summary>
        /// Gets and sets the property TagStatus. 
        /// <para>
        /// The tag status with which to filter your <a>ListImages</a> results. You can filter
        /// results based on whether they are <code>TAGGED</code> or <code>UNTAGGED</code>.
        /// </para>
        /// </summary>
        public TagStatus TagStatus
        {
            get { return this._tagStatus; }
            set { this._tagStatus = value; }
        }

        // Check to see if TagStatus property is set
        internal bool IsSetTagStatus()
        {
            return this._tagStatus != null;
        }

    }
}