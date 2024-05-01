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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteFeatureGroup operation.
    /// Delete the <c>FeatureGroup</c> and any data that was written to the <c>OnlineStore</c>
    /// of the <c>FeatureGroup</c>. Data cannot be accessed from the <c>OnlineStore</c> immediately
    /// after <c>DeleteFeatureGroup</c> is called. 
    /// 
    ///  
    /// <para>
    /// Data written into the <c>OfflineStore</c> will not be deleted. The Amazon Web Services
    /// Glue database and tables that are automatically created for your <c>OfflineStore</c>
    /// are not deleted. 
    /// </para>
    ///  
    /// <para>
    /// Note that it can take approximately 10-15 minutes to delete an <c>OnlineStore</c>
    /// <c>FeatureGroup</c> with the <c>InMemory</c> <c>StorageType</c>.
    /// </para>
    /// </summary>
    public partial class DeleteFeatureGroupRequest : AmazonSageMakerRequest
    {
        private string _featureGroupName;

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The name of the <c>FeatureGroup</c> you want to delete. The name must be unique within
        /// an Amazon Web Services Region in an Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string FeatureGroupName
        {
            get { return this._featureGroupName; }
            set { this._featureGroupName = value; }
        }

        // Check to see if FeatureGroupName property is set
        internal bool IsSetFeatureGroupName()
        {
            return this._featureGroupName != null;
        }

    }
}