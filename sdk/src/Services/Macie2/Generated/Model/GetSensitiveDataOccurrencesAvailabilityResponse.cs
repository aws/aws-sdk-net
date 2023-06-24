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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the GetSensitiveDataOccurrencesAvailability operation.
    /// </summary>
    public partial class GetSensitiveDataOccurrencesAvailabilityResponse : AmazonWebServiceResponse
    {
        private AvailabilityCode _code;
        private List<string> _reasons = new List<string>();

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// Specifies whether occurrences of sensitive data can be retrieved for the finding.
        /// Possible values are: AVAILABLE, the sensitive data can be retrieved; and, UNAVAILABLE,
        /// the sensitive data can't be retrieved. If this value is UNAVAILABLE, the reasons array
        /// indicates why the data can't be retrieved.
        /// </para>
        /// </summary>
        public AvailabilityCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Reasons. 
        /// <para>
        /// Specifies why occurrences of sensitive data can't be retrieved for the finding. Possible
        /// values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// INVALID_CLASSIFICATION_RESULT - Amazon Macie can't verify the location of the sensitive
        /// data to retrieve. There isn't a corresponding sensitive data discovery result for
        /// the finding. Or the sensitive data discovery result specified by the ClassificationDetails.detailedResultsLocation
        /// field of the finding isn't available, is malformed or corrupted, or uses an unsupported
        /// storage format.
        /// </para>
        /// </li> <li>
        /// <para>
        /// OBJECT_EXCEEDS_SIZE_QUOTA - The storage size of the affected S3 object exceeds the
        /// size quota for retrieving occurrences of sensitive data.
        /// </para>
        /// </li> <li>
        /// <para>
        /// OBJECT_UNAVAILABLE - The affected S3 object isn't available. The object might have
        /// been renamed, moved, or deleted. Or the object was changed after Macie created the
        /// finding.
        /// </para>
        /// </li> <li>
        /// <para>
        /// UNSUPPORTED_FINDING_TYPE - The specified finding isn't a sensitive data finding.
        /// </para>
        /// </li> <li>
        /// <para>
        /// UNSUPPORTED_OBJECT_TYPE - The affected S3 object uses a file or storage format that
        /// Macie doesn't support for retrieving occurrences of sensitive data.
        /// </para>
        /// </li></ul> 
        /// <para>
        /// This value is null if sensitive data can be retrieved for the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public List<string> Reasons
        {
            get { return this._reasons; }
            set { this._reasons = value; }
        }

        // Check to see if Reasons property is set
        internal bool IsSetReasons()
        {
            return this._reasons != null && this._reasons.Count > 0; 
        }

    }
}