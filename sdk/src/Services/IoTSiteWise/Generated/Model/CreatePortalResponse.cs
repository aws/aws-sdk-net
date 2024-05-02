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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the CreatePortal operation.
    /// </summary>
    public partial class CreatePortalResponse : AmazonWebServiceResponse
    {
        private string _portalArn;
        private string _portalId;
        private string _portalStartUrl;
        private PortalStatus _portalStatus;
        private string _ssoApplicationId;

        /// <summary>
        /// Gets and sets the property PortalArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the portal, which has the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:${Partition}:iotsitewise:${Region}:${Account}:portal/${PortalId}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string PortalArn
        {
            get { return this._portalArn; }
            set { this._portalArn = value; }
        }

        // Check to see if PortalArn property is set
        internal bool IsSetPortalArn()
        {
            return this._portalArn != null;
        }

        /// <summary>
        /// Gets and sets the property PortalId. 
        /// <para>
        /// The ID of the created portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string PortalId
        {
            get { return this._portalId; }
            set { this._portalId = value; }
        }

        // Check to see if PortalId property is set
        internal bool IsSetPortalId()
        {
            return this._portalId != null;
        }

        /// <summary>
        /// Gets and sets the property PortalStartUrl. 
        /// <para>
        /// The URL for the IoT SiteWise Monitor portal. You can use this URL to access portals
        /// that use IAM Identity Center for authentication. For portals that use IAM for authentication,
        /// you must use the IoT SiteWise console to get a URL that you can use to access the
        /// portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string PortalStartUrl
        {
            get { return this._portalStartUrl; }
            set { this._portalStartUrl = value; }
        }

        // Check to see if PortalStartUrl property is set
        internal bool IsSetPortalStartUrl()
        {
            return this._portalStartUrl != null;
        }

        /// <summary>
        /// Gets and sets the property PortalStatus. 
        /// <para>
        /// The status of the portal, which contains a state (<c>CREATING</c> after successfully
        /// calling this operation) and any error message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PortalStatus PortalStatus
        {
            get { return this._portalStatus; }
            set { this._portalStatus = value; }
        }

        // Check to see if PortalStatus property is set
        internal bool IsSetPortalStatus()
        {
            return this._portalStatus != null;
        }

        /// <summary>
        /// Gets and sets the property SsoApplicationId. 
        /// <para>
        /// The associated IAM Identity Center application ID, if the portal uses IAM Identity
        /// Center.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string SsoApplicationId
        {
            get { return this._ssoApplicationId; }
            set { this._ssoApplicationId = value; }
        }

        // Check to see if SsoApplicationId property is set
        internal bool IsSetSsoApplicationId()
        {
            return this._ssoApplicationId != null;
        }

    }
}