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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// This is the response object from the GenerateMatchId operation.
    /// </summary>
    public partial class GenerateMatchIdResponse : AmazonWebServiceResponse
    {
        private List<FailedRecord> _failedRecords = AWSConfigs.InitializeCollections ? new List<FailedRecord>() : null;
        private List<MatchGroup> _matchGroups = AWSConfigs.InitializeCollections ? new List<MatchGroup>() : null;

        /// <summary>
        /// Gets and sets the property FailedRecords. 
        /// <para>
        ///  The records that didn't receive a generated Match ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<FailedRecord> FailedRecords
        {
            get { return this._failedRecords; }
            set { this._failedRecords = value; }
        }

        // Check to see if FailedRecords property is set
        internal bool IsSetFailedRecords()
        {
            return this._failedRecords != null && (this._failedRecords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MatchGroups. 
        /// <para>
        ///  The match groups from the generated match ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MatchGroup> MatchGroups
        {
            get { return this._matchGroups; }
            set { this._matchGroups = value; }
        }

        // Check to see if MatchGroups property is set
        internal bool IsSetMatchGroups()
        {
            return this._matchGroups != null && (this._matchGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}