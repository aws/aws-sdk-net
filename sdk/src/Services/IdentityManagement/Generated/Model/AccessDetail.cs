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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// An object that contains details about when a principal in the reported Organizations
    /// entity last attempted to access an Amazon Web Services service. A principal can be
    /// an IAM user, an IAM role, or the Amazon Web Services account root user within the
    /// reported Organizations entity.
    /// 
    ///  
    /// <para>
    /// This data type is a response element in the <a>GetOrganizationsAccessReport</a> operation.
    /// </para>
    /// </summary>
    public partial class AccessDetail
    {
        private string _entityPath;
        private DateTime? _lastAuthenticatedTime;
        private string _region;
        private string _serviceName;
        private string _serviceNamespace;
        private int? _totalAuthenticatedEntities;

        /// <summary>
        /// Gets and sets the property EntityPath. 
        /// <para>
        /// The path of the Organizations entity (root, organizational unit, or account) from
        /// which an authenticated principal last attempted to access the service. Amazon Web
        /// Services does not report unauthenticated requests.
        /// </para>
        ///  
        /// <para>
        /// This field is null if no principals (IAM users, IAM roles, or root user) in the reported
        /// Organizations entity attempted to access the service within the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#service-last-accessed-reporting-period">tracking
        /// period</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=427)]
        public string EntityPath
        {
            get { return this._entityPath; }
            set { this._entityPath = value; }
        }

        // Check to see if EntityPath property is set
        internal bool IsSetEntityPath()
        {
            return this._entityPath != null;
        }

        /// <summary>
        /// Gets and sets the property LastAuthenticatedTime. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when an authenticated principal most recently attempted to access the
        /// service. Amazon Web Services does not report unauthenticated requests.
        /// </para>
        ///  
        /// <para>
        /// This field is null if no principals in the reported Organizations entity attempted
        /// to access the service within the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#service-last-accessed-reporting-period">tracking
        /// period</a>.
        /// </para>
        /// </summary>
        public DateTime LastAuthenticatedTime
        {
            get { return this._lastAuthenticatedTime.GetValueOrDefault(); }
            set { this._lastAuthenticatedTime = value; }
        }

        // Check to see if LastAuthenticatedTime property is set
        internal bool IsSetLastAuthenticatedTime()
        {
            return this._lastAuthenticatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region where the last service access attempt occurred.
        /// </para>
        ///  
        /// <para>
        /// This field is null if no principals in the reported Organizations entity attempted
        /// to access the service within the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#service-last-accessed-reporting-period">tracking
        /// period</a>.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service in which access was attempted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNamespace. 
        /// <para>
        /// The namespace of the service in which access was attempted.
        /// </para>
        ///  
        /// <para>
        /// To learn the service namespace of a service, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/reference_policies_actions-resources-contextkeys.html">Actions,
        /// resources, and condition keys for Amazon Web Services services</a> in the <i>Service
        /// Authorization Reference</i>. Choose the name of the service to view details for that
        /// service. In the first paragraph, find the service prefix. For example, <code>(service
        /// prefix: a4b)</code>. For more information about service namespaces, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#genref-aws-service-namespaces">Amazon
        /// Web Services service namespaces</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ServiceNamespace
        {
            get { return this._serviceNamespace; }
            set { this._serviceNamespace = value; }
        }

        // Check to see if ServiceNamespace property is set
        internal bool IsSetServiceNamespace()
        {
            return this._serviceNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property TotalAuthenticatedEntities. 
        /// <para>
        /// The number of accounts with authenticated principals (root user, IAM users, and IAM
        /// roles) that attempted to access the service in the tracking period.
        /// </para>
        /// </summary>
        public int TotalAuthenticatedEntities
        {
            get { return this._totalAuthenticatedEntities.GetValueOrDefault(); }
            set { this._totalAuthenticatedEntities = value; }
        }

        // Check to see if TotalAuthenticatedEntities property is set
        internal bool IsSetTotalAuthenticatedEntities()
        {
            return this._totalAuthenticatedEntities.HasValue; 
        }

    }
}