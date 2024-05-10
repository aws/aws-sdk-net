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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
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
namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Describes properties used to specify configurations related to a source API.
    /// </summary>
    public partial class SourceApiAssociationConfig
    {
        private MergeType _mergeType;

        /// <summary>
        /// Gets and sets the property MergeType. 
        /// <para>
        /// The property that indicates which merging option is enabled in the source API association.
        /// </para>
        ///  
        /// <para>
        /// Valid merge types are <c>MANUAL_MERGE</c> (default) and <c>AUTO_MERGE</c>. Manual
        /// merges are the default behavior and require the user to trigger any changes from the
        /// source APIs to the merged API manually. Auto merges subscribe the merged API to the
        /// changes performed on the source APIs so that any change in the source APIs are also
        /// made to the merged API. Auto merges use <c>MergedApiExecutionRoleArn</c> to perform
        /// merge operations.
        /// </para>
        /// </summary>
        public MergeType MergeType
        {
            get { return this._mergeType; }
            set { this._mergeType = value; }
        }

        // Check to see if MergeType property is set
        internal bool IsSetMergeType()
        {
            return this._mergeType != null;
        }

    }
}