﻿/*******************************************************************************
 *  Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;
using System.Text;

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// 	<para>
    /// 	Provides configuration options for how <see cref="TransferUtility"/> processes requests.
    /// 	</para>
    /// 	<para>
    /// 	The best configuration settings depend on network
    /// 	configuration, latency and bandwidth. 
    /// 	The default configuration settings are suitable
    /// 	for most applications, but this class enables developers to experiment with
    /// 	different configurations and tune transfer manager performance.
    /// 	</para>
    /// </summary>
    public class TransferUtilityConfig
    {
        long _minSizeBeforePartUpload = 16 * (long)Math.Pow(2, 20);
        int _numberOfThreads;
        int _defaultTimeout = 5 * 60 * 1000; // Default value is 5 minutes.


        /// <summary>
        /// Default constructor.
        /// </summary>
        public TransferUtilityConfig()
        {
            this.NumberOfUploadThreads = 10;
        }

        /// <summary>
        /// Gets or sets the minimum part size for upload parts. 
        /// Decreasing the minimum part size causes 
        /// multipart uploads to be split into a larger number
        /// of smaller parts. Setting this value too low has a negative effect
        /// on transfer speeds, causing extra latency and network
        /// communication for each part.
        /// </summary>
        public long MinSizeBeforePartUpload
        {
            get { return this._minSizeBeforePartUpload; }
            set { this._minSizeBeforePartUpload = value; }
        }

        /// <summary>
        /// 	Gets or sets the number of executing threads.
        /// 	This property determines how many active threads will be used to upload 
        /// 	the file. The default value is 10 threads.
        /// 	
        ///     If this property is set to a value greater then <seealso cref="System.Net.ServicePointManager.DefaultConnectionLimit"/> than
        ///     <seealso cref="System.Net.ServicePointManager.DefaultConnectionLimit"/> will be updated to the value.  If simultaneous uploads are being
        ///     done then consider increasing the <seealso cref="System.Net.ServicePointManager.DefaultConnectionLimit"/> property.
        /// </summary>
        /// <remarks>
        /// 	A value less than or equal to 0 will be silently ignored.
        /// </remarks>
        public int NumberOfUploadThreads
        {
            get { return this._numberOfThreads; }
            set
            {
                if (value < 1)
                    value = 1;

                this._numberOfThreads = value;
                if (ServicePointManager.DefaultConnectionLimit < value)
                {
                    ServicePointManager.DefaultConnectionLimit = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the default timeout in milliseconds used for writing objects to S3.  The default value is 5 minutes.
        /// </summary>
        public int DefaultTimeout
        {
            get { return this._defaultTimeout; }
            set { this._defaultTimeout = value; }
        }
    }
}
