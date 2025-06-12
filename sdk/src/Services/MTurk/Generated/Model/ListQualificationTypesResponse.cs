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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
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
namespace Amazon.MTurk.Model
{
    /// <summary>
    /// This is the response object from the ListQualificationTypes operation.
    /// </summary>
    public partial class ListQualificationTypesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private int? _numResults;
        private List<QualificationType> _qualificationTypes = AWSConfigs.InitializeCollections ? new List<QualificationType>() : null;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property NumResults. 
        /// <para>
        ///  The number of Qualification types on this page in the filtered results list, equivalent
        /// to the number of types this operation returns. 
        /// </para>
        /// </summary>
        public int? NumResults
        {
            get { return this._numResults; }
            set { this._numResults = value; }
        }

        // Check to see if NumResults property is set
        internal bool IsSetNumResults()
        {
            return this._numResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QualificationTypes. 
        /// <para>
        ///  The list of QualificationType elements returned by the query. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<QualificationType> QualificationTypes
        {
            get { return this._qualificationTypes; }
            set { this._qualificationTypes = value; }
        }

        // Check to see if QualificationTypes property is set
        internal bool IsSetQualificationTypes()
        {
            return this._qualificationTypes != null && (this._qualificationTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}