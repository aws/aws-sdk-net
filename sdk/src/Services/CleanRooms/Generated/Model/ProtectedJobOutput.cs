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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Contains details about the protected job output.
    /// </summary>
    public partial class ProtectedJobOutput
    {
        private List<ProtectedJobSingleMemberOutput> _memberList = AWSConfigs.InitializeCollections ? new List<ProtectedJobSingleMemberOutput>() : null;
        private ProtectedJobS3Output _s3;

        /// <summary>
        /// Gets and sets the property MemberList. 
        /// <para>
        /// The list of member Amazon Web Services account(s) that received the results of the
        /// job. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProtectedJobSingleMemberOutput> MemberList
        {
            get { return this._memberList; }
            set { this._memberList = value; }
        }

        // Check to see if MemberList property is set
        internal bool IsSetMemberList()
        {
            return this._memberList != null && (this._memberList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// If present, the output for a protected job with an `S3` output type.
        /// </para>
        /// </summary>
        public ProtectedJobS3Output S3
        {
            get { return this._s3; }
            set { this._s3 = value; }
        }

        // Check to see if S3 property is set
        internal bool IsSetS3()
        {
            return this._s3 != null;
        }

    }
}