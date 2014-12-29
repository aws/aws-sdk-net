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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */

using System;
using System.Collections.Generic;

using Amazon.Runtime.Resources;
using Amazon.Glacier;
using Amazon.Glacier.Model;

namespace Amazon.Glacier.Resources
{
    /// <summary>    
    /// A service is the entry point for using the Resource API. This class allows you to 
    /// access the top-level resources and operations associated with the
    /// Amazon Glacier service.
    /// </summary>
    public class Glacier : Service<IAmazonGlacier>
    {

        #region Constructors

        /// <summary>
        /// Constructs Glacier with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public Glacier() : base(new AmazonGlacierClient()) {}

        /// <summary>
        /// Constructs Glacier with an instance of AmazonGlacierClient.
        /// </summary>     
        /// <param name="client">The AmazonGlacierClient to use for requests.</param>   
        public Glacier(IAmazonGlacier client)
            : base(client)
        {
            this.ShouldDisposeClient = false;
        }

        #endregion
 
        # region Methods for service-level operations

        /// <summary>
        /// Calls the CreateVault operation on the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVault operation.</param>
        /// <returns>An instance of the Vault resource.</returns>
        public IVault CreateVault(CreateVaultRequest request)
        {
            request.AccountId = "-";
            var response = ResourcesUtilities.Invoke(request, this.Client.CreateVault, "CreateVault");
            return new Internal.Vault(accountId : request.AccountId, name : request.VaultName, client : this.Client);
            
        }
        /// <summary>
        /// Calls the CreateVault on the service.
        /// </summary>
        /// <param name="accountId">The <code>AccountId</code> is the AWS Account ID. You can specify either the AWS Account ID or optionally a '-', in which case Amazon Glacier uses the AWS Account ID associated with the credentials used to sign the request. If you specify your Account ID, do not include hyphens in it. </param>
        /// <param name="vaultName">The name of the vault.</param>
        /// <returns>An IVault associated with the service.</returns>
        public IVault CreateVault(string accountId, string vaultName)
        {
            var request = new CreateVaultRequest();
            request.AccountId = accountId;
            request.VaultName = vaultName;
            return CreateVault(request);
         }


        #endregion

        #region Methods to get resource collections associated with the service
        /// <summary>
        /// Gets the Vaults associated with the service.
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVaultsEnumerator operation.</param>
        /// <returns>An IEnumerable&lt;IVault&gt; that contains the Vaults associated with the service.</returns>
        public IEnumerable<IVault> GetVaults(ListVaultsRequest request)
        {
                        request.AccountId = "-";
        
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListVaultsEnumerator, "Vaults"))
            {            
                yield return new Internal.Vault(model : item, accountId : request.AccountId, client : this.Client);    
            }

        }

        /// <summary>
        /// Gets the Vaults associated with the service.
        /// </summary>
        /// <returns>An IEnumerable&lt;IVault&gt; that contains the Vaults associated with the service.</returns>
        public IEnumerable<IVault> GetVaults()
        {
            var request = new ListVaultsRequest();
            return GetVaults(request);
         }


        #endregion

        #region Methods to get individual resources associated with the service

        /// <summary>
        /// Gets a Account resource associated with the service using 
        /// its identifier.
        /// <para>
        /// This method does not make a service call, it returns a resource instance
        /// only with its identifier properties initialized. Accessing any non-identifier 
        /// properties or operations on the resource that in turn access any non-identifier 
        /// properties will cause the resource to make a service call to load its data.
        /// </para>
        /// <para>
        /// NOTE : This method does not make a service call when the resource is initally
        /// constructed. If you pass invalid identifiers to this method, it will return a resource
        /// that may not exist on the server. In this case an exception will be thrown when 
        /// the resource tries to load itself due to conditions listed in the previous section.
        /// </para>
        /// </summary>
        /// <param name="id">The id of the Account.</param>
        /// <returns>An instance of Account resource.</returns>

        public IAccount GetAccountById(string id)
        {
            return new Internal.Account(id : id, client : this.Client);
        }

        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion
    }
}