/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes a request to cancel a Spot Instance.</para>
    /// </summary>
    public class CancelledSpotInstanceRequest
    {
        
        private string spotInstanceRequestId;
        private CancelSpotInstanceRequestState state;


        /// <summary>
        /// The ID of the Spot Instance request.
        ///  
        /// </summary>
        public string SpotInstanceRequestId
        {
            get { return this.spotInstanceRequestId; }
            set { this.spotInstanceRequestId = value; }
        }

        // Check to see if SpotInstanceRequestId property is set
        internal bool IsSetSpotInstanceRequestId()
        {
            return this.spotInstanceRequestId != null;
        }

        /// <summary>
        /// The state of the Spot Instance request.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>active, open, closed, cancelled, completed</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public CancelSpotInstanceRequestState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }
    }
}
