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
    /// The retention policy for data stored on an Amazon Elastic File System volume.
    /// </summary>
    public partial class RetentionPolicy
    {
        private RetentionType _homeEfsFileSystem;

        /// <summary>
        /// Gets and sets the property HomeEfsFileSystem. 
        /// <para>
        /// The default is <c>Retain</c>, which specifies to keep the data stored on the Amazon
        /// EFS volume.
        /// </para>
        ///  
        /// <para>
        /// Specify <c>Delete</c> to delete the data stored on the Amazon EFS volume.
        /// </para>
        /// </summary>
        public RetentionType HomeEfsFileSystem
        {
            get { return this._homeEfsFileSystem; }
            set { this._homeEfsFileSystem = value; }
        }

        // Check to see if HomeEfsFileSystem property is set
        internal bool IsSetHomeEfsFileSystem()
        {
            return this._homeEfsFileSystem != null;
        }

    }
}