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
    /// Container for the parameters to the ListServerCertificates operation.
    /// Lists the server certificates that have the specified path prefix. If none exist,
    /// the action            returns an empty list.
    /// 
    ///         
    /// <para>
    /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>            parameters.
    /// </para>
    /// </summary>
    public partial class ListServerCertificatesRequest : AmazonWebServiceRequest
    {
        private string _marker;
        private int? _maxItems;
        private string _pathPrefix;


        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this only when paginating results, and only in a subsequent request after you've
        /// received            a response where the results are truncated. Set it to the value of the
        /// <code>Marker</code>            element in the response you just received.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }


        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListServerCertificatesRequest WithMarker(string marker)
        {
            this._marker = marker;
            return this;
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }


        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Use this only when paginating results to indicate the maximum number of server certificates            you
        /// want in the response. If there are additional server certificates beyond the maximum
        /// you            specify, the <code>IsTruncated</code> response element will be set to <code>true</code>.
        /// This            parameter is optional. If you do not include it, it defaults to 100.
        /// </para>
        /// </summary>
        public int MaxItems
        {
            get { return this._maxItems.GetValueOrDefault(); }
            set { this._maxItems = value; }
        }


        /// <summary>
        /// Sets the MaxItems property
        /// </summary>
        /// <param name="maxItems">The value to set for the MaxItems property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListServerCertificatesRequest WithMaxItems(int maxItems)
        {
            this._maxItems = maxItems;
            return this;
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property PathPrefix. 
        /// <para>
        /// The path prefix for filtering the results. For example: <code>/company/servercerts</code>            would
        /// get all server certificates for which the path starts with                <code>/company/servercerts</code>.
        /// </para>
        ///         
        /// <para>
        /// This parameter is optional. If it is not included, it defaults to a slash (/), listing
        /// all            server certificates.
        /// </para>
        /// </summary>
        public string PathPrefix
        {
            get { return this._pathPrefix; }
            set { this._pathPrefix = value; }
        }


        /// <summary>
        /// Sets the PathPrefix property
        /// </summary>
        /// <param name="pathPrefix">The value to set for the PathPrefix property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListServerCertificatesRequest WithPathPrefix(string pathPrefix)
        {
            this._pathPrefix = pathPrefix;
            return this;
        }

        // Check to see if PathPrefix property is set
        internal bool IsSetPathPrefix()
        {
            return this._pathPrefix != null;
        }

    }
}