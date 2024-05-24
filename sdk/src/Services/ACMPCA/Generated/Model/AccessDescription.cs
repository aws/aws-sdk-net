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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
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
namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Provides access information used by the <c>authorityInfoAccess</c> and <c>subjectInfoAccess</c>
    /// extensions described in <a href="https://datatracker.ietf.org/doc/html/rfc5280">RFC
    /// 5280</a>.
    /// </summary>
    public partial class AccessDescription
    {
        private GeneralName _accessLocation;
        private AccessMethod _accessMethod;

        /// <summary>
        /// Gets and sets the property AccessLocation. 
        /// <para>
        /// The location of <c>AccessDescription</c> information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GeneralName AccessLocation
        {
            get { return this._accessLocation; }
            set { this._accessLocation = value; }
        }

        // Check to see if AccessLocation property is set
        internal bool IsSetAccessLocation()
        {
            return this._accessLocation != null;
        }

        /// <summary>
        /// Gets and sets the property AccessMethod. 
        /// <para>
        /// The type and format of <c>AccessDescription</c> information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccessMethod AccessMethod
        {
            get { return this._accessMethod; }
            set { this._accessMethod = value; }
        }

        // Check to see if AccessMethod property is set
        internal bool IsSetAccessMethod()
        {
            return this._accessMethod != null;
        }

    }
}