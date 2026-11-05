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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains details about the most recent attempt to access an action within the service.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetServiceLastAccessedDetails.html">GetServiceLastAccessedDetails</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class TrackedActionLastAccessed
    {
        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// The name of the tracked action to which access was attempted. Tracked actions are
        /// actions that report activity to IAM.
        /// </para>
        /// </summary>
        public string ActionName { get; set; }

        /// <summary>
        /// Checks to see if the ActionName property is set.
        /// </summary>
        internal bool IsSetActionName() => this.ActionName != null;

        /// <summary>
        /// Gets and sets the property LastAccessedEntity.
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string LastAccessedEntity { get; set; }

        /// <summary>
        /// Checks to see if the LastAccessedEntity property is set.
        /// </summary>
        internal bool IsSetLastAccessedEntity() => this.LastAccessedEntity != null;

        /// <summary>
        /// Gets and sets the property LastAccessedRegion. 
        /// <para>
        /// The Region from which the authenticated entity (user or role) last attempted to access
        /// the tracked action. Amazon Web Services does not report unauthenticated requests.
        /// </para>
        ///  
        /// <para>
        /// This field is null if no IAM entities attempted to access the service within the <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#service-last-accessed-reporting-period">tracking
        /// period</a>.
        /// </para>
        /// </summary>
        public string LastAccessedRegion { get; set; }

        /// <summary>
        /// Checks to see if the LastAccessedRegion property is set.
        /// </summary>
        internal bool IsSetLastAccessedRegion() => this.LastAccessedRegion != null;

        /// <summary>
        /// Gets and sets the property LastAccessedTime. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when an authenticated entity most recently attempted to access the tracked
        /// service. Amazon Web Services does not report unauthenticated requests.
        /// </para>
        ///  
        /// <para>
        /// This field is null if no IAM entities attempted to access the service within the <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#service-last-accessed-reporting-period">tracking
        /// period</a>.
        /// </para>
        /// </summary>
        public DateTime? LastAccessedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastAccessedTime property is set.
        /// </summary>
        internal bool IsSetLastAccessedTime() => this.LastAccessedTime.HasValue;
    }
}
