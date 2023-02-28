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
    /// Provides information about the status of a sensitive data finding.
    /// </summary>
    public partial class ClassificationResultStatus
    {
        private string _code;
        private string _reason;

        /// <summary>
        /// Gets and sets the property Code.  
        /// <para>
        /// The status of the finding. Possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// COMPLETE - Amazon Macie successfully completed its analysis of the S3 object that
        /// the finding applies to.
        /// </para>
        /// </li> <li>
        /// <para>
        /// PARTIAL - Macie analyzed only a subset of the data in the S3 object that the finding
        /// applies to. For example, the object is an archive file that contains files in an unsupported
        /// format.
        /// </para>
        /// </li> <li>
        /// <para>
        /// SKIPPED - Macie wasn't able to analyze the S3 object that the finding applies to.
        /// For example, the object is a file that uses an unsupported format.
        /// </para>
        /// </li></ul>
        /// </summary>
        public string Code
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
        /// Gets and sets the property Reason. 
        /// <para>
        /// A brief description of the status of the finding. This value is null if the status
        /// (code) of the finding is COMPLETE.
        /// </para>
        ///  
        /// <para>
        /// Amazon Macie uses this value to notify you of any errors, warnings, or considerations
        /// that might impact your analysis of the finding and the affected S3 object. Possible
        /// values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// ARCHIVE_CONTAINS_UNPROCESSED_FILES - The object is an archive file and Macie extracted
        /// and analyzed only some or none of the files in the archive. To determine which files
        /// Macie analyzed, if any, refer to the corresponding sensitive data discovery result
        /// for the finding (ClassificationDetails.detailedResultsLocation).
        /// </para>
        /// </li> <li>
        /// <para>
        /// ARCHIVE_EXCEEDS_SIZE_LIMIT - The object is an archive file whose total storage size
        /// exceeds the size quota for this type of archive.
        /// </para>
        /// </li> <li>
        /// <para>
        /// ARCHIVE_NESTING_LEVEL_OVER_LIMIT - The object is an archive file whose nested depth
        /// exceeds the quota for the maximum number of nested levels that Macie analyzes for
        /// this type of archive.
        /// </para>
        /// </li> <li>
        /// <para>
        /// ARCHIVE_TOTAL_BYTES_EXTRACTED_OVER_LIMIT - The object is an archive file that exceeds
        /// the quota for the maximum amount of data that Macie extracts and analyzes for this
        /// type of archive.
        /// </para>
        /// </li> <li>
        /// <para>
        /// ARCHIVE_TOTAL_DOCUMENTS_PROCESSED_OVER_LIMIT - The object is an archive file that
        /// contains more than the maximum number of files that Macie extracts and analyzes for
        /// this type of archive.
        /// </para>
        /// </li> <li>
        /// <para>
        /// FILE_EXCEEDS_SIZE_LIMIT - The storage size of the object exceeds the size quota for
        /// this type of file.
        /// </para>
        /// </li> <li>
        /// <para>
        /// INVALID_ENCRYPTION - The object is encrypted using server-side encryption but Macie
        /// isn't allowed to use the key. Macie can't decrypt and analyze the object.
        /// </para>
        /// </li> <li>
        /// <para>
        /// INVALID_KMS_KEY - The object is encrypted with an KMS key that was disabled or is
        /// being deleted. Macie can't decrypt and analyze the object.
        /// </para>
        /// </li> <li>
        /// <para>
        /// INVALID_OBJECT_STATE - The object doesn't use a supported Amazon S3 storage class.
        /// </para>
        /// </li> <li>
        /// <para>
        /// JSON_NESTING_LEVEL_OVER_LIMIT - The object contains JSON data and the nested depth
        /// of the data exceeds the quota for the number of nested levels that Macie analyzes
        /// for this type of file.
        /// </para>
        /// </li> <li>
        /// <para>
        /// MALFORMED_FILE - The object is a malformed or corrupted file. An error occurred when
        /// Macie attempted to detect the file's type or extract data from the file.
        /// </para>
        /// </li> <li>
        /// <para>
        /// MALFORMED_OR_FILE_SIZE_EXCEEDS_LIMIT - The object is a Microsoft Office file that
        /// is malformed or exceeds the size quota for this type of file. If the file is malformed,
        /// an error occurred when Macie attempted to extract data from the file.
        /// </para>
        /// </li> <li>
        /// <para>
        /// NO_SUCH_BUCKET_AVAILABLE - The object was in a bucket that was deleted shortly before
        /// or when Macie attempted to analyze the object.
        /// </para>
        /// </li> <li>
        /// <para>
        /// OBJECT_VERSION_MISMATCH - The object was changed while Macie was analyzing it.
        /// </para>
        /// </li> <li>
        /// <para>
        /// OOXML_UNCOMPRESSED_RATIO_EXCEEDS_LIMIT - The object is an Office Open XML file whose
        /// compression ratio exceeds the compression quota for this type of file.
        /// </para>
        /// </li> <li>
        /// <para>
        /// OOXML_UNCOMPRESSED_SIZE_EXCEEDS_LIMIT - The object is an Office Open XML file that
        /// exceeds the size quota for this type of file.
        /// </para>
        /// </li> <li>
        /// <para>
        /// PERMISSION_DENIED - Macie isn't allowed to access the object. The object's permissions
        /// settings prevent Macie from analyzing the object.
        /// </para>
        /// </li> <li>
        /// <para>
        /// SOURCE_OBJECT_NO_LONGER_AVAILABLE - The object was deleted shortly before or when
        /// Macie attempted to analyze it.
        /// </para>
        /// </li> <li>
        /// <para>
        /// TIME_CUT_OFF_REACHED - Macie started analyzing the object but additional analysis
        /// would exceed the time quota for analyzing an object.
        /// </para>
        /// </li> <li>
        /// <para>
        /// UNABLE_TO_PARSE_FILE - The object is a file that contains structured data and an error
        /// occurred when Macie attempted to parse the data.
        /// </para>
        /// </li> <li>
        /// <para>
        /// UNSUPPORTED_FILE_TYPE_EXCEPTION - The object is a file that uses an unsupported file
        /// or storage format.
        /// </para>
        /// </li></ul> 
        /// <para>
        /// For information about quotas, supported storage classes, and supported file and storage
        /// formats, see <a href="https://docs.aws.amazon.com/macie/latest/user/macie-quotas.html">Quotas</a>
        /// and <a href="https://docs.aws.amazon.com/macie/latest/user/discovery-supported-storage.html">Supported
        /// storage classes and formats</a> in the <i>Amazon Macie User Guide</i>.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}