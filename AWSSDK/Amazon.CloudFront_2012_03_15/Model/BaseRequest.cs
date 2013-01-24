/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-11-01
 *
 */
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace Amazon.CloudFront_2012_03_15.Model
{
    /// <summary>
    /// Base class for Cloudfront operations that provides headers.
    /// </summary>
    public abstract class BaseRequest
    {
        /// <summary>
        /// The protected member that holds the service specific headers with which 
        /// the HTTP Request is configured.
        /// 
        /// This is used by all derived Requests 
        /// </summary>
        protected WebHeaderCollection headers;

        #region Headers

        /// <summary>
        /// Gets the Headers property.
        /// </summary>
        internal WebHeaderCollection Headers
        {
            get
            {
                if (this.headers == null)
                {
                    this.headers = new WebHeaderCollection();
                }
                return this.headers;
            }
        }

        /// <summary>
        /// Checks if Headers property is set
        /// </summary>
        /// <returns>true if Headers property is set</returns>
        internal bool IsSetHeaders()
        {
            return (this.headers != null) && 
                (this.headers.Count > 0);
        }

        /// <summary>
        /// Adds all of the key/value pairs from collection into our request header.
        /// </summary>
        /// <param name="collection">A collection of key/value headers</param>
        public void AddHeaders(NameValueCollection collection)
        {
            this.Headers.Add(collection);
        }

        #endregion
    }
}
