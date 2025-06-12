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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the GetSensitiveDataOccurrencesAvailability operation.
    /// </summary>
    public partial class GetSensitiveDataOccurrencesAvailabilityResponse : AmazonWebServiceResponse
    {
        private AvailabilityCode _code;
        private List<string> _reasons = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// ACCOUNT_NOT_IN_ORGANIZATION - The affected account isn't currently part of your organization.
        /// Or the account is part of your organization but Macie isn't currently enabled for
        /// the account. You're not allowed to access the affected S3 object by using Macie.
        /// </para>
        /// </li> <li>
        /// <para>
        /// INVALID_CLASSIFICATION_RESULT - There isn't a corresponding sensitive data discovery
        /// result for the finding. Or the corresponding sensitive data discovery result isn't
        /// available in the current Amazon Web Services Region, is malformed or corrupted, or
        /// uses an unsupported storage format. Macie can't verify the location of the sensitive
        /// data to retrieve.
        /// </para>
        /// </li> <li>
        /// <para>
        /// INVALID_RESULT_SIGNATURE - The corresponding sensitive data discovery result is stored
        /// in an S3 object that wasn't signed by Macie. Macie can't verify the integrity and
        /// authenticity of the sensitive data discovery result. Therefore, Macie can't verify
        /// the location of the sensitive data to retrieve.
        /// </para>
        /// </li> <li>
        /// <para>
        /// MEMBER_ROLE_TOO_PERMISSIVE - The trust or permissions policy for the IAM role in the
        /// affected member account doesn't meet Macie requirements for restricting access to
        /// the role. Or the role's trust policy doesn't specify the correct external ID for your
        /// organization. Macie can't assume the role to retrieve the sensitive data.
        /// </para>
        /// </li> <li>
        /// <para>
        /// MISSING_GET_MEMBER_PERMISSION - You're not allowed to retrieve information about the
        /// association between your account and the affected account. Macie can't determine whether
        /// you’re allowed to access the affected S3 object as the delegated Macie administrator
        /// for the affected account.
        /// </para>
        /// </li> <li>
        /// <para>
        /// OBJECT_EXCEEDS_SIZE_QUOTA - The storage size of the affected S3 object exceeds the
        /// size quota for retrieving occurrences of sensitive data from this type of file.
        /// </para>
        /// </li> <li>
        /// <para>
        /// OBJECT_UNAVAILABLE - The affected S3 object isn't available. The object was renamed,
        /// moved, deleted, or changed after Macie created the finding. Or the object is encrypted
        /// with an KMS key that isn’t available. For example, the key is disabled, is scheduled
        /// for deletion, or was deleted.
        /// </para>
        /// </li> <li>
        /// <para>
        /// RESULT_NOT_SIGNED - The corresponding sensitive data discovery result is stored in
        /// an S3 object that hasn't been signed. Macie can't verify the integrity and authenticity
        /// of the sensitive data discovery result. Therefore, Macie can't verify the location
        /// of the sensitive data to retrieve.
        /// </para>
        /// </li> <li>
        /// <para>
        /// ROLE_TOO_PERMISSIVE - Your account is configured to retrieve occurrences of sensitive
        /// data by using an IAM role whose trust or permissions policy doesn't meet Macie requirements
        /// for restricting access to the role. Macie can’t assume the role to retrieve the sensitive
        /// data.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._reasons != null && (this._reasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}