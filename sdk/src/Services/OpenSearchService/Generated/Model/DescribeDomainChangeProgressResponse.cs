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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The result of a <c>DescribeDomainChangeProgress</c> request. Contains progress information
    /// for the requested domain change.
    /// </summary>
    public partial class DescribeDomainChangeProgressResponse : AmazonWebServiceResponse
    {
        private ChangeProgressStatusDetails _changeProgressStatus;

        /// <summary>
        /// Gets and sets the property ChangeProgressStatus. 
        /// <para>
        /// Container for information about the stages of a configuration change happening on
        /// a domain.
        /// </para>
        /// </summary>
        public ChangeProgressStatusDetails ChangeProgressStatus
        {
            get { return this._changeProgressStatus; }
            set { this._changeProgressStatus = value; }
        }

        // Check to see if ChangeProgressStatus property is set
        internal bool IsSetChangeProgressStatus()
        {
            return this._changeProgressStatus != null;
        }

    }
}