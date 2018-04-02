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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// This is the response object from the ListFieldLevelEncryptionProfiles operation.
    /// </summary>
    public partial class ListFieldLevelEncryptionProfilesResponse : AmazonWebServiceResponse
    {
        private FieldLevelEncryptionProfileList _fieldLevelEncryptionProfileList;

        /// <summary>
        /// Gets and sets the property FieldLevelEncryptionProfileList. 
        /// <para>
        /// Returns a list of the field-level encryption profiles that have been created in CloudFront
        /// for this account.
        /// </para>
        /// </summary>
        public FieldLevelEncryptionProfileList FieldLevelEncryptionProfileList
        {
            get { return this._fieldLevelEncryptionProfileList; }
            set { this._fieldLevelEncryptionProfileList = value; }
        }

        // Check to see if FieldLevelEncryptionProfileList property is set
        internal bool IsSetFieldLevelEncryptionProfileList()
        {
            return this._fieldLevelEncryptionProfileList != null;
        }

    }
}