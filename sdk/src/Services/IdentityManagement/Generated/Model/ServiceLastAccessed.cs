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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains details about the most recent attempt to access the service.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetServiceLastAccessedDetails.html">GetServiceLastAccessedDetails</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class ServiceLastAccessed
    {
        private DateTime? _lastAuthenticated;
        private string _lastAuthenticatedEntity;
        private string _lastAuthenticatedRegion;
        private string _serviceName;
        private string _serviceNamespace;
        private int? _totalAuthenticatedEntities;
        private List<TrackedActionLastAccessed> _trackedActionsLastAccessed = AWSConfigs.InitializeCollections ? new List<TrackedActionLastAccessed>() : null;

        /// <summary>
        /// Gets and sets the property LastAuthenticated. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when an authenticated entity most recently attempted to access the service.
        /// Amazon Web Services does not report unauthenticated requests.
        /// </para>
        ///  
        /// <para>
        /// This field is null if no IAM entities attempted to access the service within the <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#service-last-accessed-reporting-period">tracking
        /// period</a>.
        /// </para>
        /// </summary>
        public DateTime? LastAuthenticated
        {
            get { return this._lastAuthenticated; }
            set { this._lastAuthenticated = value; }
        }

        // Check to see if LastAuthenticated property is set
        internal bool IsSetLastAuthenticated()
        {
            return this._lastAuthenticated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastAuthenticatedEntity. 
        /// <para>
        /// The ARN of the authenticated entity (user or role) that last attempted to access the
        /// service. Amazon Web Services does not report unauthenticated requests.
        /// </para>
        ///  
        /// <para>
        /// This field is null if no IAM entities attempted to access the service within the <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#service-last-accessed-reporting-period">tracking
        /// period</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string LastAuthenticatedEntity
        {
            get { return this._lastAuthenticatedEntity; }
            set { this._lastAuthenticatedEntity = value; }
        }

        // Check to see if LastAuthenticatedEntity property is set
        internal bool IsSetLastAuthenticatedEntity()
        {
            return this._lastAuthenticatedEntity != null;
        }

        /// <summary>
        /// Gets and sets the property LastAuthenticatedRegion. 
        /// <para>
        /// The Region from which the authenticated entity (user or role) last attempted to access
        /// the service. Amazon Web Services does not report unauthenticated requests.
        /// </para>
        ///  
        /// <para>
        /// This field is null if no IAM entities attempted to access the service within the <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#service-last-accessed-reporting-period">tracking
        /// period</a>.
        /// </para>
        /// </summary>
        public string LastAuthenticatedRegion
        {
            get { return this._lastAuthenticatedRegion; }
            set { this._lastAuthenticatedRegion = value; }
        }

        // Check to see if LastAuthenticatedRegion property is set
        internal bool IsSetLastAuthenticatedRegion()
        {
            return this._lastAuthenticatedRegion != null;
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
        /// service. In the first paragraph, find the service prefix. For example, <c>(service
        /// prefix: a4b)</c>. For more information about service namespaces, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#genref-aws-service-namespaces">Amazon
        /// Web Services Service Namespaces</a> in the <i>Amazon Web Services General Reference</i>.
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
        /// The total number of authenticated principals (root user, IAM users, or IAM roles)
        /// that have attempted to access the service.
        /// </para>
        ///  
        /// <para>
        /// This field is null if no principals attempted to access the service within the <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#service-last-accessed-reporting-period">tracking
        /// period</a>.
        /// </para>
        /// </summary>
        public int? TotalAuthenticatedEntities
        {
            get { return this._totalAuthenticatedEntities; }
            set { this._totalAuthenticatedEntities = value; }
        }

        // Check to see if TotalAuthenticatedEntities property is set
        internal bool IsSetTotalAuthenticatedEntities()
        {
            return this._totalAuthenticatedEntities.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrackedActionsLastAccessed. 
        /// <para>
        /// An object that contains details about the most recent attempt to access a tracked
        /// action within the service.
        /// </para>
        ///  
        /// <para>
        /// This field is null if there no tracked actions or if the principal did not use the
        /// tracked actions within the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#service-last-accessed-reporting-period">tracking
        /// period</a>. This field is also null if the report was generated at the service level
        /// and not the action level. For more information, see the <c>Granularity</c> field in
        /// <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GenerateServiceLastAccessedDetails.html">GenerateServiceLastAccessedDetails</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TrackedActionLastAccessed> TrackedActionsLastAccessed
        {
            get { return this._trackedActionsLastAccessed; }
            set { this._trackedActionsLastAccessed = value; }
        }

        // Check to see if TrackedActionsLastAccessed property is set
        internal bool IsSetTrackedActionsLastAccessed()
        {
            return this._trackedActionsLastAccessed != null && (this._trackedActionsLastAccessed.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}