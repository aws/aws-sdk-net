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
 * Do not modify this file. This file is generated from the directory-service-data-2023-05-31.normal.json service model.
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
namespace Amazon.DirectoryServiceData.Model
{
    /// <summary>
    /// This is the response object from the CreateUser operation.
    /// </summary>
    public partial class CreateUserResponse : AmazonWebServiceResponse
    {
        private string _directoryId;
        private string _samAccountName;
        private string _sid;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        ///  The identifier (ID) of the directory where the address block is added. 
        /// </para>
        /// </summary>
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property SAMAccountName. 
        /// <para>
        ///  The name of the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string SAMAccountName
        {
            get { return this._samAccountName; }
            set { this._samAccountName = value; }
        }

        // Check to see if SAMAccountName property is set
        internal bool IsSetSAMAccountName()
        {
            return this._samAccountName != null;
        }

        /// <summary>
        /// Gets and sets the property SID. 
        /// <para>
        ///  The unique security identifier (SID) of the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SID
        {
            get { return this._sid; }
            set { this._sid = value; }
        }

        // Check to see if SID property is set
        internal bool IsSetSID()
        {
            return this._sid != null;
        }

    }
}