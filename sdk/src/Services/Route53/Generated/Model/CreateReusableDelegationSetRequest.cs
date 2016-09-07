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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the CreateReusableDelegationSet operation.
    /// Creates a delegation set (a group of four anem servers) that can be reused by multiple
    /// hosted zones. If a hosted zoned ID is specified, <code>CreateReusableDelegationSet</code>
    /// marks the delegation set associated with that zone as reusable
    /// 
    ///  
    /// <para>
    /// Send a <code>POST</code> request to the <code>/<i>Amazon Route 53 API version</i>/delegationset</code>
    /// resource. The request body must include an XML document with a <code>CreateReusableDelegationSetRequest</code>
    /// element.
    /// </para>
    ///  <note> 
    /// <para>
    /// A reusable delegation set cannot be associated with a private hosted zone/
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information, including a procedure on how to create and configure a reusable
    /// delegation set (also known as white label name servers), see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/white-label-name-servers.html">Configuring
    /// White Label Name Servers</a>.
    /// </para>
    /// </summary>
    public partial class CreateReusableDelegationSetRequest : AmazonRoute53Request
    {
        private string _callerReference;
        private string _hostedZoneId;

        /// <summary>
        /// Gets and sets the property CallerReference. 
        /// <para>
        /// A unique string that identifies the request, and that allows you to retry failed <code>CreateReusableDelegationSet</code>
        /// requests without the risk of executing the operation twice. You must use a unique
        /// <code>CallerReference</code> string every time you submit a <code>CreateReusableDelegationSet</code>
        /// request. <code>CallerReference</code> can be any unique string, for example a date/time
        /// stamp.
        /// </para>
        /// </summary>
        public string CallerReference
        {
            get { return this._callerReference; }
            set { this._callerReference = value; }
        }

        // Check to see if CallerReference property is set
        internal bool IsSetCallerReference()
        {
            return this._callerReference != null;
        }

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// If you want to mark the delegation set for an existing hosted zone as reusable, the
        /// ID for that hosted zone.
        /// </para>
        /// </summary>
        public string HostedZoneId
        {
            get { return this._hostedZoneId; }
            set { this._hostedZoneId = value; }
        }

        // Check to see if HostedZoneId property is set
        internal bool IsSetHostedZoneId()
        {
            return this._hostedZoneId != null;
        }

    }
}