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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
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
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Container for the parameters to the StartAssessmentFrameworkShare operation.
    /// Creates a share request for a custom framework in Audit Manager. 
    /// 
    ///  
    /// <para>
    /// The share request specifies a recipient and notifies them that a custom framework
    /// is available. Recipients have 120 days to accept or decline the request. If no action
    /// is taken, the share request expires.
    /// </para>
    ///  
    /// <para>
    /// When you create a share request, Audit Manager stores a snapshot of your custom framework
    /// in the US East (N. Virginia) Amazon Web Services Region. Audit Manager also stores
    /// a backup of the same snapshot in the US West (Oregon) Amazon Web Services Region.
    /// </para>
    ///  
    /// <para>
    /// Audit Manager deletes the snapshot and the backup snapshot when one of the following
    /// events occurs:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The sender revokes the share request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The recipient declines the share request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The recipient encounters an error and doesn't successfully accept the share request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The share request expires before the recipient responds to the request.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When a sender <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/framework-sharing.html#framework-sharing-resend">resends
    /// a share request</a>, the snapshot is replaced with an updated version that corresponds
    /// with the latest version of the custom framework. 
    /// </para>
    ///  
    /// <para>
    /// When a recipient accepts a share request, the snapshot is replicated into their Amazon
    /// Web Services account under the Amazon Web Services Region that was specified in the
    /// share request. 
    /// </para>
    ///  <important> 
    /// <para>
    /// When you invoke the <c>StartAssessmentFrameworkShare</c> API, you are about to share
    /// a custom framework with another Amazon Web Services account. You may not share a custom
    /// framework that is derived from a standard framework if the standard framework is designated
    /// as not eligible for sharing by Amazon Web Services, unless you have obtained permission
    /// to do so from the owner of the standard framework. To learn more about which standard
    /// frameworks are eligible for sharing, see <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/share-custom-framework-concepts-and-terminology.html#eligibility">Framework
    /// sharing eligibility</a> in the <i>Audit Manager User Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class StartAssessmentFrameworkShareRequest : AmazonAuditManagerRequest
    {
        private string _comment;
        private string _destinationAccount;
        private string _destinationRegion;
        private string _frameworkId;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        ///  An optional comment from the sender about the share request. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationAccount. 
        /// <para>
        ///  The Amazon Web Services account of the recipient. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string DestinationAccount
        {
            get { return this._destinationAccount; }
            set { this._destinationAccount = value; }
        }

        // Check to see if DestinationAccount property is set
        internal bool IsSetDestinationAccount()
        {
            return this._destinationAccount != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationRegion. 
        /// <para>
        ///  The Amazon Web Services Region of the recipient. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationRegion
        {
            get { return this._destinationRegion; }
            set { this._destinationRegion = value; }
        }

        // Check to see if DestinationRegion property is set
        internal bool IsSetDestinationRegion()
        {
            return this._destinationRegion != null;
        }

        /// <summary>
        /// Gets and sets the property FrameworkId. 
        /// <para>
        ///  The unique identifier for the custom framework to be shared. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string FrameworkId
        {
            get { return this._frameworkId; }
            set { this._frameworkId = value; }
        }

        // Check to see if FrameworkId property is set
        internal bool IsSetFrameworkId()
        {
            return this._frameworkId != null;
        }

    }
}