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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// This is the response object from the ListProvisionedCapacity operation.
    /// </summary>
    public partial class ListProvisionedCapacityResponse : AmazonWebServiceResponse
    {
        private List<ProvisionedCapacityDescription> _provisionedCapacityList = new List<ProvisionedCapacityDescription>();

        /// <summary>
        /// Gets and sets the property ProvisionedCapacityList. 
        /// <para>
        /// The response body contains the following JSON fields.
        /// </para>
        /// </summary>
        public List<ProvisionedCapacityDescription> ProvisionedCapacityList
        {
            get { return this._provisionedCapacityList; }
            set { this._provisionedCapacityList = value; }
        }

        // Check to see if ProvisionedCapacityList property is set
        internal bool IsSetProvisionedCapacityList()
        {
            return this._provisionedCapacityList != null && this._provisionedCapacityList.Count > 0; 
        }

    }
}