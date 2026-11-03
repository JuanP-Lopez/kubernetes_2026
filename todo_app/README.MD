# 1.8. The project, step 5

Solution for Exercise 1.8. The project, step 5

## Description

The app has a setup with a Ingress.

The Todo App responds to HTTP GET requests sent to the / endpoint with a message indicating 
that the application is running. The application responds `TODO app is running in Port NNNN.`.

## Run in Kubernetes

Cluster creation:
```powershell
k3d cluster create --port 8082:30080@agent:0 -p 8081:80@loadbalancer --agents 2
```

Apply the Deployment:
```powershell
kubectl apply -f .\todo_app\manifests\deployment.yaml
```

Apply the Service:
```powershell
kubectl apply -f .\todo_app\manifests\service.yaml
```

Apply the Ingress:
```bash
kubectl apply -f .\todo_app\manifests\ingress.yaml
```

Access the application:
```bash
http://localhost:8081/
```

## Screenshots

![Application Running](./screenshots/web_request_ingress.png)