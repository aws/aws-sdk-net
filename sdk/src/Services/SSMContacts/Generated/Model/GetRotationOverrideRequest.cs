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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
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
namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Container for the parameters to the GetRotationOverride operation.
    /// Retrieves information about an override to an on-call rotation.
    /// </summary>
    public partial class GetRotationOverrideRequest : AmazonSSMContactsRequest
    {
        private string _rotationId;
        private string _rotationOverrideId;

        /// <summary>
        /// Gets and sets the property RotationId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the overridden rotation to retrieve information
        /// about.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RotationId
        {
            get { return this._rotationId; }
            set { this._rotationId = value; }
        }

        // Check to see if RotationId property is set
        internal bool IsSetRotationId()
        {
            return this._rotationId != null;
        }

        /// <summary>
        /// Gets and sets the property RotationOverrideId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the on-call rotation override to retrieve information
        /// about.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=39)]
        public string RotationOverrideId
        {
            get { return this._rotationOverrideId; }
            set { this._rotationOverrideId = value; }
        }

        // Check to see if RotationOverrideId property is set
        internal bool IsSetRotationOverrideId()
        {
            return this._rotationOverrideId != null;
        }

    }
}