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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
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
namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// Resource permission for a dataset. When you create a dataset, all the other members
    /// of the same user group inherit access to the dataset. You can only create a dataset
    /// if your user group has application permission for Create Datasets.
    /// 
    ///  
    /// <para>
    /// The following is a list of valid dataset permissions that you can apply: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>ViewDatasetDetails</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ReadDatasetDetails</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>AddDatasetData</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CreateDataView</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>EditDatasetMetadata</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DeleteDataset</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information on the dataset permissions, see <a href="https://docs.aws.amazon.com/finspace/latest/userguide/managing-user-permissions.html#supported-dataset-permissions">Supported
    /// Dataset Permissions</a> in the FinSpace User Guide.
    /// </para>
    /// </summary>
    public partial class ResourcePermission
    {
        private string _permission;

        /// <summary>
        /// Gets and sets the property Permission. 
        /// <para>
        /// Permission for a resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public string Permission
        {
            get { return this._permission; }
            set { this._permission = value; }
        }

        // Check to see if Permission property is set
        internal bool IsSetPermission()
        {
            return this._permission != null;
        }

    }
}