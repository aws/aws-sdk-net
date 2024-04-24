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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
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
namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// This is the response object from the ApplySchema operation.
    /// </summary>
    public partial class ApplySchemaResponse : AmazonWebServiceResponse
    {
        private string _appliedSchemaArn;
        private string _directoryArn;

        /// <summary>
        /// Gets and sets the property AppliedSchemaArn. 
        /// <para>
        /// The applied schema ARN that is associated with the copied schema in the <a>Directory</a>.
        /// You can use this ARN to describe the schema information applied on this directory.
        /// For more information, see <a>arns</a>.
        /// </para>
        /// </summary>
        public string AppliedSchemaArn
        {
            get { return this._appliedSchemaArn; }
            set { this._appliedSchemaArn = value; }
        }

        // Check to see if AppliedSchemaArn property is set
        internal bool IsSetAppliedSchemaArn()
        {
            return this._appliedSchemaArn != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The ARN that is associated with the <a>Directory</a>. For more information, see <a>arns</a>.
        /// </para>
        /// </summary>
        public string DirectoryArn
        {
            get { return this._directoryArn; }
            set { this._directoryArn = value; }
        }

        // Check to see if DirectoryArn property is set
        internal bool IsSetDirectoryArn()
        {
            return this._directoryArn != null;
        }

    }
}