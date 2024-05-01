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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
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
namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// This is the response object from the DeleteWorkgroup operation.
    /// </summary>
    public partial class DeleteWorkgroupResponse : AmazonWebServiceResponse
    {
        private Workgroup _workgroup;

        /// <summary>
        /// Gets and sets the property Workgroup. 
        /// <para>
        /// The deleted workgroup object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Workgroup Workgroup
        {
            get { return this._workgroup; }
            set { this._workgroup = value; }
        }

        // Check to see if Workgroup property is set
        internal bool IsSetWorkgroup()
        {
            return this._workgroup != null;
        }

    }
}