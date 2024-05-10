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
 * Do not modify this file. This file is generated from the servicecatalog-appregistry-2020-06-24.normal.json service model.
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
namespace Amazon.AppRegistry.Model
{
    /// <summary>
    /// This is the response object from the SyncResource operation.
    /// </summary>
    public partial class SyncResourceResponse : AmazonWebServiceResponse
    {
        private SyncAction _actionTaken;
        private string _applicationArn;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ActionTaken. 
        /// <para>
        /// The results of the output if an application is associated with an ARN value, which
        /// could be <c>syncStarted</c> or None.
        /// </para>
        /// </summary>
        public SyncAction ActionTaken
        {
            get { return this._actionTaken; }
            set { this._actionTaken = value; }
        }

        // Check to see if ActionTaken property is set
        internal bool IsSetActionTaken()
        {
            return this._actionTaken != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The Amazon resource name (ARN) that specifies the application.
        /// </para>
        /// </summary>
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon resource name (ARN) that specifies the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}