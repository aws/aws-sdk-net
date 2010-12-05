﻿/*******************************************************************************
 *  Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The SetNotificationConfigurationRequest contains the parameters used for the SetNotificationConfiguration operation.
    /// If the NotificationConfiguration is null or empty then the current configuration will be cleared.
    /// <br />Required Parameters: BucketName
    /// </summary>
    public class SetNotificationConfigurationRequest : S3Request
    {
        #region Private Members

        private string bucketName;
        private NotificationConfigurationList notificationConfig = new NotificationConfigurationList();

        #endregion

        #region Properties

        /// <summary>
        /// Gets and sets the BucketName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get
            {
                return this.bucketName;
            }
            set
            {
                this.bucketName = value;
            }
        }

        /// <summary>
        /// Sets the BucketName property for this request.
        /// This is the S3 Bucket the request will get the location for.
        /// </summary>
        /// <param name="bucketName">The value that BucketName is set to</param>
        /// <returns>this instance</returns>
        public SetNotificationConfigurationRequest WithBucketName(string bucketName)
        {
            this.BucketName = bucketName;
            return this;
        }

        /// <summary>
        /// Checks if BucketName property is set.
        /// </summary>
        /// <returns>true if BucketName property is set.</returns>
        internal bool IsSetBucketName()
        {
            return !System.String.IsNullOrEmpty(this.BucketName);
        }

        /// <summary>
        /// Gets and sets the NotificationConfiguration property.
        /// </summary>
        public NotificationConfigurationList NotificationConfiguration
        {
            get
            {
                return this.notificationConfig;
            }
            set
            {
                this.notificationConfig = value;
            }
        }

        /// <summary>
        /// Sets the NotificationConfiguration property for this request.
        /// </summary>
        /// <param name="notificationConfig">The value that NotificationConfiguration is set to</param>
        /// <returns>this instance</returns>
        public SetNotificationConfigurationRequest WithNotificationConfiguration(NotificationConfigurationList notificationConfig)
        {
            this.notificationConfig = notificationConfig;
            return this;
        }


        #endregion
    }
}
