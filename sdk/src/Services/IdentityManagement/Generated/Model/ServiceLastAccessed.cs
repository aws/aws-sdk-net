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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains details about the most recent attempt to access the service.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a>GetServiceLastAccessedDetails</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class ServiceLastAccessed
    {
        private DateTime? _lastAuthenticated;
        private string _lastAuthenticatedEntity;
        private string _serviceName;
        private string _serviceNamespace;
        private int? _totalAuthenticatedEntities;

        /// <summary>
        /// Gets and sets the property LastAuthenticated. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when an authenticated entity most recently attempted to access the service.
        /// AWS does not report unauthenticated requests.
        /// </para>
        ///  
        /// <para>
        /// This field is null if no IAM entities attempted to access the service within the <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#service-last-accessed-reporting-period">reporting
        /// period</a>.
        /// </para>
        /// </summary>
        public DateTime LastAuthenticated
        {
            get { return this._lastAuthenticated.GetValueOrDefault(); }
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
        /// service. AWS does not report unauthenticated requests.
        /// </para>
        ///  
        /// <para>
        /// This field is null if no IAM entities attempted to access the service within the <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#service-last-accessed-reporting-period">reporting
        /// period</a>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service in which access was attempted.
        /// </para>
        /// </summary>
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
        /// To learn the service namespace of a service, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_actions-resources-contextkeys.html">Actions,
        /// Resources, and Condition Keys for AWS Services</a> in the <i>IAM User Guide</i>. Choose
        /// the name of the service to view details for that service. In the first paragraph,
        /// find the service prefix. For example, <code>(service prefix: a4b)</code>. For more
        /// information about service namespaces, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#genref-aws-service-namespaces">AWS
        /// Service Namespaces</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </summary>
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
        /// The total number of authenticated entities that have attempted to access the service.
        /// </para>
        ///  
        /// <para>
        /// This field is null if no IAM entities attempted to access the service within the <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#service-last-accessed-reporting-period">reporting
        /// period</a>.
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