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
 * Do not modify this file. This file is generated from the ssm-quicksetup-2018-05-10.normal.json service model.
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
namespace Amazon.SSMQuickSetup.Model
{
    /// <summary>
    /// This is the response object from the ListQuickSetupTypes operation.
    /// </summary>
    public partial class ListQuickSetupTypesResponse : AmazonWebServiceResponse
    {
        private List<QuickSetupTypeOutput> _quickSetupTypeList = AWSConfigs.InitializeCollections ? new List<QuickSetupTypeOutput>() : null;

        /// <summary>
        /// Gets and sets the property QuickSetupTypeList. 
        /// <para>
        /// An array of Quick Setup types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<QuickSetupTypeOutput> QuickSetupTypeList
        {
            get { return this._quickSetupTypeList; }
            set { this._quickSetupTypeList = value; }
        }

        // Check to see if QuickSetupTypeList property is set
        internal bool IsSetQuickSetupTypeList()
        {
            return this._quickSetupTypeList != null && (this._quickSetupTypeList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}