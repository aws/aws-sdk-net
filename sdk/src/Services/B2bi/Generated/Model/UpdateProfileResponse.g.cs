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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.B2bi.Model
{
    /// <summary>
    /// This is the response object from the UpdateProfile operation.
    /// </summary>
    public partial class UpdateProfileResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BusinessName. 
        /// <para>
        /// Returns the name for the business associated with this profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 254)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Checks to see if the BusinessName property is set.
        /// </summary>
        internal bool IsSetBusinessName() => this.BusinessName != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Returns a timestamp for creation date and time of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// Returns the email address associated with this customer profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 5, Max = 254)]
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// Returns the name of the logging group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupName property is set.
        /// </summary>
        internal bool IsSetLogGroupName() => this.LogGroupName != null;

        /// <summary>
        /// Gets and sets the property Logging. 
        /// <para>
        /// Specifies whether or not logging is enabled for this profile.
        /// </para>
        /// </summary>
        public Logging Logging { get; set; }

        /// <summary>
        /// Checks to see if the Logging property is set.
        /// </summary>
        internal bool IsSetLogging() => this.Logging != null;

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// Returns a timestamp for last time the profile was modified.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Returns the name of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 254)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Phone. 
        /// <para>
        /// Returns the phone number associated with the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 7, Max = 22)]
        public string Phone { get; set; }

        /// <summary>
        /// Checks to see if the Phone property is set.
        /// </summary>
        internal bool IsSetPhone() => this.Phone != null;

        /// <summary>
        /// Gets and sets the property ProfileArn. 
        /// <para>
        /// Returns an Amazon Resource Name (ARN) for the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the ProfileArn property is set.
        /// </summary>
        internal bool IsSetProfileArn() => this.ProfileArn != null;

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// Returns the unique, system-generated identifier for the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileId property is set.
        /// </summary>
        internal bool IsSetProfileId() => this.ProfileId != null;
    }
}
