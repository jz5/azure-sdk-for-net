// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.ApiManagement;
using Microsoft.Azure.Management.ApiManagement.SmapiModels;

namespace Microsoft.Azure.Management.ApiManagement
{
    /// <summary>
    /// .Net client wrapper for the REST API for Azure ApiManagement Service
    /// </summary>
    public static partial class TenantAccessGitOperationsExtensions
    {
        /// <summary>
        /// Get tenant settings.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ITenantAccessGitOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <returns>
        /// Get Tenant Access Information operation response details.
        /// </returns>
        public static AccessInformationGetResponse Get(this ITenantAccessGitOperations operations, string resourceGroupName, string serviceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITenantAccessGitOperations)s).GetAsync(resourceGroupName, serviceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get tenant settings.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ITenantAccessGitOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <returns>
        /// Get Tenant Access Information operation response details.
        /// </returns>
        public static Task<AccessInformationGetResponse> GetAsync(this ITenantAccessGitOperations operations, string resourceGroupName, string serviceName)
        {
            return operations.GetAsync(resourceGroupName, serviceName, CancellationToken.None);
        }
        
        /// <summary>
        /// Regenerate primary access key.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ITenantAccessGitOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse RegeneratePrimaryKey(this ITenantAccessGitOperations operations, string resourceGroupName, string serviceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITenantAccessGitOperations)s).RegeneratePrimaryKeyAsync(resourceGroupName, serviceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Regenerate primary access key.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ITenantAccessGitOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> RegeneratePrimaryKeyAsync(this ITenantAccessGitOperations operations, string resourceGroupName, string serviceName)
        {
            return operations.RegeneratePrimaryKeyAsync(resourceGroupName, serviceName, CancellationToken.None);
        }
        
        /// <summary>
        /// Regenerate secondary access key.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ITenantAccessGitOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse RegenerateSecondaryKey(this ITenantAccessGitOperations operations, string resourceGroupName, string serviceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ITenantAccessGitOperations)s).RegenerateSecondaryKeyAsync(resourceGroupName, serviceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Regenerate secondary access key.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.ApiManagement.ITenantAccessGitOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// Required. The name of the Api Management service.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> RegenerateSecondaryKeyAsync(this ITenantAccessGitOperations operations, string resourceGroupName, string serviceName)
        {
            return operations.RegenerateSecondaryKeyAsync(resourceGroupName, serviceName, CancellationToken.None);
        }
    }
}