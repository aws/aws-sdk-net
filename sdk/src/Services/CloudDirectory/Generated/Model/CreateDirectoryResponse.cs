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
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// This is the response object from the CreateDirectory operation.
    /// </summary>
    public partial class CreateDirectoryResponse : AmazonWebServiceResponse
    {
        private string _appliedSchemaArn;
        private string _directoryArn;
        private string _name;
        private string _objectIdentifier;

        /// <summary>
        /// Gets and sets the property AppliedSchemaArn. 
        /// <para>
        /// ARN of the published schema in the <a>Directory</a>. Once a published schema is copied
        /// into the directory, it has its own ARN which is referred to applied schema ARN. For
        /// more information, see <a>arns</a>.
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
        /// ARN associated with the <a>Directory</a>. For more information, see <a>arns</a>.
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

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the <a>Directory</a>.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectIdentifier. 
        /// <para>
        /// The root object node of the created directory.
        /// </para>
        /// </summary>
        public string ObjectIdentifier
        {
            get { return this._objectIdentifier; }
            set { this._objectIdentifier = value; }
        }

        // Check to see if ObjectIdentifier property is set
        internal bool IsSetObjectIdentifier()
        {
            return this._objectIdentifier != null;
        }

    }
}