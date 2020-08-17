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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Container for the parameters to the PutAppsList operation.
    /// Creates an AWS Firewall Manager applications list.
    /// </summary>
    public partial class PutAppsListRequest : AmazonFMSRequest
    {
        private AppsListData _appsList;
        private List<Tag> _tagList = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AppsList. 
        /// <para>
        /// The details of the AWS Firewall Manager applications list to be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AppsListData AppsList
        {
            get { return this._appsList; }
            set { this._appsList = value; }
        }

        // Check to see if AppsList property is set
        internal bool IsSetAppsList()
        {
            return this._appsList != null;
        }

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        /// The tags associated with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> TagList
        {
            get { return this._tagList; }
            set { this._tagList = value; }
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this._tagList != null && this._tagList.Count > 0; 
        }

    }
}