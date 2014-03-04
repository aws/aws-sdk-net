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
 *  API Version: 2006-03-01
 *
 */

using System;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The DeleteObjectResponse contains any headers returned by S3.
    /// </summary>
    public class DeleteObjectResponse : S3Response
    {
        private bool isDeleteMarker;

        /// <summary>
        /// Gets and sets the IsDeleteMarker property.
        /// Specifies whether the object deleted was (true) or 
        /// was not (false) a Delete Marker.
        /// </summary>
        public bool IsDeleteMarker
        {
            get { return this.isDeleteMarker; }
            set { this.isDeleteMarker = value; }
        }

        /// <summary>
        /// Gets and sets the Headers property.
        /// </summary>
        public override System.Net.WebHeaderCollection Headers
        {
            set
            {
                base.Headers = value;

                string hdr = null;
                if (!String.IsNullOrEmpty(hdr = value.Get(Util.S3Constants.AmzDeleteMarkerHeader)))
                {
                    isDeleteMarker = System.Convert.ToBoolean(hdr);
                }
            }
        }
    }
}