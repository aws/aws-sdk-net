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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Contains information that denied the authorization.
    /// </summary>
    public partial class Denied
    {
        private ExplicitDeny _explicitDeny;
        private ImplicitDeny _implicitDeny;

        /// <summary>
        /// Gets and sets the property ExplicitDeny. 
        /// <para>
        /// Information that explicitly denies the authorization. 
        /// </para>
        /// </summary>
        public ExplicitDeny ExplicitDeny
        {
            get { return this._explicitDeny; }
            set { this._explicitDeny = value; }
        }

        // Check to see if ExplicitDeny property is set
        internal bool IsSetExplicitDeny()
        {
            return this._explicitDeny != null;
        }

        /// <summary>
        /// Gets and sets the property ImplicitDeny. 
        /// <para>
        /// Information that implicitly denies the authorization. When a policy doesn't explicitly
        /// deny or allow an action on a resource it is considered an implicit deny.
        /// </para>
        /// </summary>
        public ImplicitDeny ImplicitDeny
        {
            get { return this._implicitDeny; }
            set { this._implicitDeny = value; }
        }

        // Check to see if ImplicitDeny property is set
        internal bool IsSetImplicitDeny()
        {
            return this._implicitDeny != null;
        }

    }
}