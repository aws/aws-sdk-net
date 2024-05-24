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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// An S3 bucket where you want to store the results of this request.
    /// 
    ///  
    /// <para>
    /// For the minimal permissions required to enable Amazon S3 output for an association,
    /// see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/state-manager-associations-creating.html#state-manager-associations-console">Create
    /// an association (console)</a> in the <i>Systems Manager User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class InstanceAssociationOutputLocation
    {
        private S3OutputLocation _s3Location;

        /// <summary>
        /// Gets and sets the property S3Location. 
        /// <para>
        /// An S3 bucket where you want to store the results of this request.
        /// </para>
        /// </summary>
        public S3OutputLocation S3Location
        {
            get { return this._s3Location; }
            set { this._s3Location = value; }
        }

        // Check to see if S3Location property is set
        internal bool IsSetS3Location()
        {
            return this._s3Location != null;
        }

    }
}